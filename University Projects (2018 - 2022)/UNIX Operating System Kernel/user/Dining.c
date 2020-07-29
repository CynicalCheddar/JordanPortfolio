/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */

#include "Dining.h"
#include "libc.h"
#include "PL011.h"
extern void main_Philosopher();


int philosopherCount = 16;

void main_Dining() {
  // stack, data
  int myPid = requestPid();



  for( int i = 0; i < philosopherCount; i++ ) {
    write( STDOUT_FILENO, "DINE", 4 );
    // call fork
     if( 0 == fork() ) {
       exec( &main_Philosopher );
     }

     
    // call exec
  }
  // Initialise control channel data. This sets the pid offset of each program. This gives each process a reference to all others.
  // Initially, all pids are contiguous in memory. This only matters for the initial setup.

  // Do do this we are hijacking the channel controller.
  for( int i = 0; i < philosopherCount; i++ ) {
    int philosopherPid = myPid + 1 + i;
    makeChannel(philosopherPid, myPid);
  }

  while(1){
    for (int i = 0; i < 10000000; i++) {
      
    }
}
  exit( EXIT_SUCCESS );
}
