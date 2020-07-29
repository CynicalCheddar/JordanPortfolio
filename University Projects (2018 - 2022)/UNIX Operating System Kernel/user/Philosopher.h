/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */

#ifndef _Philosopher_H
#define _Philosopher_H

#define maxProcs 32

#define FORK_TAKE_REQ 1
#define FORK_RETURN_REQ 2
#define FORK_DENY_REQ 3

#define FORK_TAKE_ACK 4
#define FORK_RETURN_ACK 5
#define FORK_TAKE_DENY 6

#define FORK_TAKE_WAIT 7
#define FORK_TAKE_RESUME 8
      /*         
      
                  Negative - Request
                  Positive - Acknowledgement
                  Magnitude = 1 - Take Fork 
                  Magnitude = 2 - Return Fork
                  Magnitude = 3 - Deny fork
                                                                  */


#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#include "libc.h"

#endif
