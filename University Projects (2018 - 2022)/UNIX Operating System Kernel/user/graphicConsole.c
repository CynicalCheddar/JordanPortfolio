/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */

#include "graphicConsole.h"

char* l;
int k;
int j;

/* The following functions are special-case versions of a) writing, and 
 * b) reading a string from the UART (the latter case returning once a 
 * carriage return character has been read, or a limit is reached).
 */



/* Since we lack a *real* loader (as a result of also lacking a storage
 * medium to store program images), the following function approximates 
 * one: given a program name from the set of programs statically linked
 * into the kernel image, it returns a pointer to the entry point.
 */
extern void main_P2();
extern void main_P3(); 
extern void main_P4(); 
extern void main_P5(); 
extern void main_IPC();
extern void main_alive();
extern void* load(char* x);

/* The behaviour of a console process can be summarised as an infinite 
 * loop over three main steps, namely
 *
 * 1. write a command prompt then read a command,
 * 2. tokenize command, then
 * 3. execute command.
 *
 * As is, the console only recognises the following commands:
 *
 * a. execute <program name>
 *
 *    This command will use fork to create a new process; the parent
 *    (i.e., the console) will continue as normal, whereas the child
 *    uses exec to replace the process image and thereby execute a
 *    different (named) program.  For example,
 *    
 *    execute P3
 *
 *    would execute the user program named P3.
 *
 * b. terminate <process ID> 
 *
 *    This command uses kill to send a terminate or SIG_TERM signal
 *    to a specific process (identified via the PID provided); this
 *    acts to forcibly terminate the process, vs. say that process
 *    using exit to terminate itself.  For example,
 *  
 *    terminate 3
 *
 *    would terminate the process whose PID is 3.
 */
char cmdGraphic[ MAX_CMD_CHARS ];

bool execute = false;

void addToCommandQueue(char character){
      for( int i = 0; i < MAX_CMD_CHARS; i++ ) {
        if(cmdGraphic[i] == 0){
            cmdGraphic[i] = character;
            return;
        }
      }
      return;
}



int checkStatus = 42;
char data;

void main_graphicConsole() {
  // MainBox
  drawRectangleCall(100, 20, 400, 350);
  // ProcBox
  drawRectangleCall(100, 490, 200, 210);
  while( 1 ) {


    for (int i = 0; i < 10000000; i++) {
      
    }

    // step 1: write command prompt, then read command.

        // firstly, check if the GUI has sent a command:
    if(execute == false){
      if(checkBuffer(SEM_CURPROC) != SEM_EMPTY){
        data = semRead(SEM_CURPROC);
       // write( STDOUT_FILENO, "r", 1 );
        //write( STDOUT_FILENO, &data, 1 );
          if(data == '\n'){
              // execute command, then reset cmd
              
              execute = true;
          //  addToCommandQueue(data);
          }
          else if(data != 0){
              if(data == 31) data = 32;
            addToCommandQueue(data);
          }
      }
    }

     for (int i = 0; i < 10000000; i++) {
      
    }
    

      


      

      // step 2: tokenize command.
    if(execute){
      int cmd_argc = 0; char* cmd_argv[ MAX_CMD_ARGS ];

      for( char* t = strtok( cmdGraphic, " " ); t != NULL; t = strtok( NULL, " " ) ) {
        cmd_argv[ cmd_argc++ ] = t;
      }

      // step 3: execute command.

      if     ( 0 == strcmp( cmd_argv[ 0 ], "EXECUTE"   ) ) {

        void* addr = load( cmd_argv[ 1 ] );

        if( addr != NULL ) {
          
          if( 0 == fork() ) {
          //  puts( "forked\n", 7 );
            exec( addr );
          //  puts( "execed\n", 7 );
          }
        }
        else {
        //  puts( "unknown program\n", 16 );
        write( STDOUT_FILENO, "unknown program\n", 16 );
        graphicWrite(BOX_OUTPUT, "unknown program\n", 16);
        }
      } 
      else if( 0 == strcmp( cmd_argv[ 0 ], "TERMINATE" ) ) {
        kill( atoi( cmd_argv[ 1 ] ), SIG_TERM );
      }
      else if( 0 == strcmp( cmd_argv[ 0 ], "CONNECT" ) ) {
        graphicWrite(BOX_OUTPUT, "ATTEMPTING IPC CONNECT\n", 24);
        int source = atoi(cmd_argv[ 1 ]);
        int dest = atoi( cmd_argv[ 2 ]);
        l = cmd_argv[2];
        if(dest == 0){
        }
        else{
          makeChannel(source , dest );
        }
      
      }  
      else if( 0 == strcmp( cmd_argv[ 0 ], "DISCONNECT" ) ) {
        graphicWrite(BOX_OUTPUT, "ATTEMPTING IPC DISCONNECT\n", 27);
        int source = atoi(cmd_argv[ 1 ]);
        int dest = atoi( cmd_argv[ 2 ]);
        makeChannel(source , -dest );
      }
      // List all programs
      else if( 0 == strcmp( cmd_argv[ 0 ], "LS" ) ) {
        graphicWrite(BOX_OUTPUT, " ", 1);
        graphicWrite(BOX_OUTPUT, "P3\n", 4);
        graphicWrite(BOX_OUTPUT, "P4 (unstable)\n", 15);
        graphicWrite(BOX_OUTPUT, "P5\n", 4);
        graphicWrite(BOX_OUTPUT, "IPC\n", 5);
        graphicWrite(BOX_OUTPUT, "DINE\n", 6);
        graphicWrite(BOX_OUTPUT, "ALIVE\n", 7);
      }
      else if( 0 == strcmp( cmd_argv[ 0 ], "NICE" ) ) {
        int pid = atoi(cmd_argv[ 1 ]);
        int value = atoi( cmd_argv[ 2 ]);
        nice(pid , value );
      }
      
      else {
        //puts( "unknown command\n", 16 );
        write( STDOUT_FILENO, "unknown command\n", 16 );
        graphicWrite(BOX_OUTPUT, "unknown command\n", 16);
      }
      //reset input
      memset(cmdGraphic, 0, MAX_CMD_CHARS * sizeof(char));
      execute = false;
    }

   

    
  }

  exit( EXIT_SUCCESS );
}
