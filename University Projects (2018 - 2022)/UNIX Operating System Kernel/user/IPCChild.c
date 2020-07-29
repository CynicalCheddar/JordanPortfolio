/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */
#include "IPCChild.h"


int broadcastCount = 0;
int broadcastPids[MAX_PROCS] = {0};
int pid = 0;

void addToBroadcastPids(int pid){
      for( int i = 0; i < MAX_PROCS; i++ ) {
        if(broadcastPids[i] == 0){
            broadcastPids[i] = pid;
            return;
        }
      }
      return;
}
int removeFromBroadcastPids(int pid){
  int data = 0;
  bool removed = false;
      for( int i = 0; i < MAX_PROCS; i++ ) {
        if(broadcastPids[i] != 0 && removed == false){
            data = broadcastPids[i];
            // shuffle all other values forward
            for( int j = i; j < MAX_PROCS; j++ ) {
              broadcastPids[j] = broadcastPids[j + 1];
            }
            broadcastPids[MAX_PROCS] = 0;
            removed = true;
            return data;
        }
      }
      return data;
}
bool duplicatePid(int pid){
        for( int i = 0; i < MAX_PROCS; i++ ) {
        if(broadcastPids[i] == pid){
            return true;
            
        }
      }
      return false;
}
void resetPids(){
  for( int i = 0; i < MAX_PROCS; i++ ) {
    broadcastPids[i] = 0;
  }
}



void main_IPCChild() {


while(1){
    for (int i = 0; i < 10000000; i++) {
      
    }

    // Firstly, receive our message (if there are any)
    
    if(checkBuffer(SEM_CURPROC) != SEM_EMPTY){
      char data = semRead(SEM_CURPROC);
      if(data != 0){
       // PL011_putc( UART0, data, true );
        write( STDOUT_FILENO, &data, 1 );
        graphicWrite(BOX_OUTPUT, &data, 1);
      }
    }
    if(checkBuffer(SEM_CURPROC) == SEM_EMPTY){
     // PL011_putc( UART0, "e", true );
    }

    // This whole idea should make use of producer consumer

    // Send a message to another process
    // Get a process ID.
    // Make a message (produce).
    // Decrement free spaces in item buffer (buffer located in PCB.)
    // If the buffer is full, then wait.
    
    // Request to the kernel to see if we have any new broadcast pid requests
    int request = channelControlRead();
    // check that we are not duplicating a pid request
    if(duplicatePid(request)) request = 0;
    // If we do, then either add or remove from broadcastPids

      if(request != 0){
        if(request > 0){
          addToBroadcastPids(request);
          broadcastCount +=1;
          write( STDOUT_FILENO, "REQUEST ADD", 11 );
          graphicWrite(BOX_OUTPUT, "\nCONNECT SUCCESS\n", 18);
        }
        else if(request < 0 && broadcastCount > 0){
          removeFromBroadcastPids(request);
          broadcastCount -=1;
          write( STDOUT_FILENO, "REQUEST REM", 11 );
          graphicWrite(BOX_OUTPUT, "\nDISCONNECT SUCCESS\n", 21);
          graphicWrite(BOX_OUTPUT, "EMPTYING RESIDUAL BUFFER\n", 26);
        }
      }

    if(broadcastCount<0){
      broadcastCount = 0;
      resetPids();
    }
    //Check if we actually have any broadcast Pids

    // If we do, then loop through each pid and send
    
    if(broadcastCount >= 1){
  //    
      for (int i = 0; i < broadcastCount; i++)
      {
        if(broadcastPids[i] != 0){
        if(checkBuffer(broadcastPids[i]) != SEM_FULL){
          // produce
          send(broadcastPids[i], 'a');
        }
      }    
    }
    }
}

exit( EXIT_SUCCESS );
}
