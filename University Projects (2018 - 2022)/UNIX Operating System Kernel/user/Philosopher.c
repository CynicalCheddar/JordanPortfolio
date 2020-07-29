/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */
#include "Philosopher.h"


int broadcastCountP = 16;
int broadcastPidsP[maxProcs] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};

  int pidOffset = 4;


void addToBroadcastPidsPhil(int pid){
      for( int i = 0; i < maxProcs; i++ ) {
        if(broadcastPidsP[i] == 0){
            broadcastPidsP[i] = pid;
            return;
        }
      }
      return;
}
int removeFromBroadcastPidsPhil(int pid){
  int data = 0;
  bool removed = false;
      for( int i = 0; i < maxProcs; i++ ) {
        if(broadcastPidsP[i] != 0 && removed == false){
            data = broadcastPidsP[i];
            // shuffle all other values forward
            for( int j = i; j < maxProcs; j++ ) {
              broadcastPidsP[j] = broadcastPidsP[j + 1];
            }
            broadcastPidsP[maxProcs] = 0;
            removed = true;
            return data;
        }
      }
      return data;
}
bool duplicatePidPhil(int pid){
        for( int i = 0; i < maxProcs; i++ ) {
        if(broadcastPidsP[i] == pid){
            return true;
            
        }
      }
      return false;
}
void resetPidsPhil(){
  for( int i = 0; i < maxProcs; i++ ) {
    broadcastPidsP[i] = 0;
  }
}
void broastcastSignal(int signal){
  for( int i = 0; i < maxProcs; i++ ) {
    if(broadcastPidsP[i] != 0 && broadcastPidsP[i] != requestPid()){
      send(broadcastPidsP[i], signal);
    }
  }
}


int readControlSignal(){
    int request = channelControlRead();
    // check that we are not duplicating a pid request
    // If we do, then either add or remove from broadcastPids

      if(request != 0){
        return request;
      }
      return 0;
}


void main_Philosopher() {
  int lastCommand = 0;
  int pidP = 0;
  int borrowID;
  int borrowerID;
  bool hasRightFork = true;
  bool hasLeftFork = false;
  bool acknowledged = true;
  // My fork is the rightFork
  bool myForkTaken = false;
  char data = 0;
  bool wait = false;
  bool receievedControlSignal = false;
  pidP = requestPid();



  // wait for control signal before doing anything else.
  // This tells us what our pid offset is
  while(!receievedControlSignal){
    pidOffset = channelControlRead();
    if(pidOffset != 0){
      receievedControlSignal = true;
      // Add x to all broadcast pids. Offset of pid.
      
      write( STDOUT_FILENO, "received", 9 );
    }
  }


  for(int i = 0; i<maxProcs; i++){
     if(broadcastPidsP[i] != 0){
        broadcastPidsP[i] = pidOffset + i + 1;
     }
  }

  int lowestPid = pidOffset + 1;
  int highestPid = pidOffset + 16;


  borrowID = pidP + 1;
  borrowerID = pidP - 1;
  if (borrowID > highestPid){
      borrowID = lowestPid;
  }


  if (borrowerID < lowestPid){
      borrowerID = highestPid;
  }






  while(1){
      for (int i = 0; i < 100000; i++) {
      }
      // Firstly, check channel control signals:

    if(broadcastCountP<0){
      broadcastCountP = 0;
      resetPidsPhil();
    }

      data = 0;
      if(checkBuffer(pidP) != SEM_EMPTY){
       
        data = semRead(pidP);
        if(data != 0){
           lastCommand = data;

           if(data == FORK_TAKE_REQ){
             send(borrowerID, FORK_TAKE_ACK);
             hasRightFork = false;
           }
           else if(data == FORK_TAKE_WAIT){
             wait = true;
           }
           else if(data == FORK_TAKE_ACK){
             hasLeftFork = true;
           }
           else if(data == FORK_RETURN_REQ){
             hasRightFork = true;
           }
           else if(data == FORK_TAKE_RESUME){
             wait = false;
           }
        }
      }

          // If we have our right fork, then request the left fork.
      if(hasRightFork && !hasLeftFork && !wait){
        wait = true;
       // send(borrowID, FORK_TAKE_WAIT);
       // send(borrowerID, FORK_TAKE_WAIT);
        broastcastSignal(FORK_TAKE_WAIT);
        send(borrowID, FORK_TAKE_REQ);
        
      //  graphicWrite(BOX_OUTPUT, "REQUEST TAKE FORK\n", 18);
        char d[2];
        itoa(d, pidP);
        write( STDOUT_FILENO, &d, 2 );
        write( STDOUT_FILENO, " TAKE", 9 );
      }


    // If we have both forks, then eat.
    if(hasRightFork && hasLeftFork) {

      char d[2];
      itoa(d, pidP);
      graphicWrite(BOX_OUTPUT, &d, 2);

      graphicWrite(BOX_OUTPUT, " IS EATING\n", 11);

      write( STDOUT_FILENO, &d, 2);
      write( STDOUT_FILENO, " IS EATING\n", 11);
      hasLeftFork = false;
      send(borrowID, FORK_RETURN_REQ);
      broastcastSignal(FORK_TAKE_RESUME);
     // send(borrowID, FORK_TAKE_RESUME);
      //send(borrowerID, FORK_TAKE_RESUME);
        //graphicWrite(BOX_OUTPUT, "REQUEST RETURN FORK\n", 20);
    }

    // Stop busy waiting
    //yield();
  

    
}
exit( EXIT_SUCCESS );

}
