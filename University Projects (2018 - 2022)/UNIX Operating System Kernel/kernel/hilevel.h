/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */

#ifndef __HILEVEL_H
#define __HILEVEL_H



// Include functionality relating to newlib (the standard C library).

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#include <string.h>

// Include functionality relating to the platform.
#include "SYS.h"
#include   "GIC.h"
#include "PL011.h"
#include "SP804.h"
#include "PL050.h"
#include "PL111.h"
// Include functionality relating to the   kernel.

#include "lolevel.h"
#include     "int.h"


/* The kernel source code is made simpler and more consistent by using 
 * some human-readable type definitions:
 *
 * - a type that captures a Process IDentifier (PID), which is really
 *   just an integer,
 * - an enumerated type that captures the status of a process, e.g.,
 *   whether it is currently executing,
 * - a type that captures each component of an execution context (i.e.,
 *   processor state) in a compatible order wrt. the low-level handler
 *   preservation and restoration prologue and epilogue, and
 * - a type that captures a process PCB.
 */
#define MAX_TEXT 128
#define MAX_PROCS 32
#define MAX_QUEUE 16
#define MAX_WINDOWS 5
typedef int pid_t;

typedef enum { 
  STATUS_INVALID,

  STATUS_CREATED,
  STATUS_TERMINATED,

  STATUS_READY,
  STATUS_EXECUTING,
  STATUS_WAITING
} status_t;





typedef enum { 
  PID_SEND,
  PID_REMOVE
} broadcast_type;

typedef struct {
  uint32_t cpsr, pc, gpr[ 13 ], sp, lr;
} ctx_t;

typedef struct {
  int         semaphoreQueue[MAX_QUEUE];
  // A buffer to pass the send to channel pids to each IPC process
  int         broadcastPidBuffer[MAX_QUEUE];
  int         emptyCount;
  int         fullCount;
  bool        mutexLocked;
  bool        receiving;
} ctx_ipc;

typedef struct {
  int posY;
  int posX;
  int height;
  int width;
  int cursorY;
  int cursorX;
  int fontSize;
  int spacing;
  char text[MAX_TEXT];
  int maxChars;
} text_box;

/*typedef struct {
  int    pid;
  broadcast_type     sendType;
} pid_send;*/



typedef struct {
     pid_t    pid; // Process IDentifier (PID)
  status_t status; // current status
  uint32_t    tos; // address of Top of Stack (ToS)
     ctx_t    ctx; // execution context
  uint32_t    priority;
  uint32_t    priority_base;
  uint32_t    parentPid;
  bool        full;
  ctx_ipc     ipc;
} pcb_t;

#endif
