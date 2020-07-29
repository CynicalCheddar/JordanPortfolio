/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */

#include "IPC.h"
#include "libc.h"
#include "PL011.h"
extern void main_IPCChild();




void main_IPC() {
  for( int i = 0; i < 16; i++ ) {
    write( STDOUT_FILENO, "IPC", 3 );
    // call fork
     if( 0 == fork() ) {
       exec( &main_IPCChild );
     }

     
    // call exec
  }
  graphicWrite(BOX_OUTPUT, "IPC process spawned. Type 'connect (pid) (pid)' to form a channel.\n", 68);
  graphicWrite(BOX_OUTPUT, "Type 'disconnect (pid) (pid)' to break channel\n", 48);
  while(1){
    for (int i = 0; i < 10000000; i++) {
      
    }
  /*  while(checkBuffer(2) != 0){
      char data = semRead(2);
      if(data != 0){
        PL011_putc( UART0, data, true );
      }
    }*/
}
  exit( EXIT_SUCCESS );
}
