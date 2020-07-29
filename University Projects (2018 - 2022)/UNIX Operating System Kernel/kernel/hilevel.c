/* Copyright (C) 2017 Daniel Page <csdsp@bristol.ac.uk>
 *
 * Use of this source code is restricted per the CC BY-NC-ND license, a copy of 
 * which can be found via http://creativecommons.org (and should be included as 
 * LICENSE.txt within the associated archive or repository).
 */

#include "hilevel.h"

// IO functionality
#include "basicFont.h"
#include "PS2KeyTable.h"

#include "console.h"
/* We assume there will be two user processes, stemming from execution of the 
 * two user programs P1 and P2, and can therefore
 * 
 * - allocate a fixed-size process table (of PCBs), and then maintain an index 
 *   into it to keep track of the currently executing process, and
 * - employ a fixed-case of round-robin scheduling: no more processes can be 
 *   created, and neither can be terminated, so assume both are always ready
 *   to execute.
 */

bool cursor = false;
int TEST;
int x;
int currentProcs = 1;
int maxPriorityProcessID = 0;
int currentProcessID = 1;
int currentProcessStackPos = 0;
int stackSize = 0x00010000; // HARDCODED
int highestProcessID = 1;
uint16_t fb[ 600 ][ 800 ];

pcb_t procTab[ MAX_PROCS ]; pcb_t* executing = NULL;
text_box textBoxes [MAX_WINDOWS];
char cmdBuffer[ MAX_TEXT ];
// LCD STUFF ------------------------------------
int cursorX = 0;
int cursorY = 100;
bool blockNext = false;
void putstring( char* x, int n ) {
  for( int i = 0; i < n; i++ ) {
    PL011_putc( UART1, x[ i ], true );
  }
}
// Render a character. Lookup the asci value in the bitmap font lookup table. Unpack bits and draw at position.
void renderChar(char *bitmap, int posY, int posX, int scaleFactor) {

      for( int i = 0; i < 8; i++ ) {
        for( int j = 0; j < 8; j++ ) {
          for( int k = 0; k < scaleFactor; k++ ) {
              for( int l = 0; l < scaleFactor; l++ ) {
                fb[posY + (i*scaleFactor) + k][posX + (j*scaleFactor) + l] = ((bitmap[i] >> j) & 1) * 200;
              }
          }
      }
  }
}

void addCharToTextboxBuffer(int boxID, char character){
  for(int i = 0; i < MAX_TEXT; i++){
    if(textBoxes[boxID].text[i] == 0){
      textBoxes[boxID].text[i] = character;
      return;
    }
  }
}
void removeCharFromTextboxBuffer(int boxID){
  for(int i = MAX_TEXT; i > 0; i--){
    if(textBoxes[boxID].text[i] != 0){
      textBoxes[boxID].text[i] = 0;
      return;
    }
  }
}
void addCharToCommandBuffer(char character){
  for(int i = 0; i < MAX_TEXT; i++){
    if(cmdBuffer[i] == 0 ){
      cmdBuffer[i] = character;
      return;
    }
  }
}
void displayPids(){
  resetTextBox(BOX_GENERAL);
  renderString("Active pIDs: \n", BOX_GENERAL, 15);
  for(int i = 0; i < MAX_PROCS; i++){
    if(procTab[i].pid != 0){
      char pidString[3];
      itoa(pidString, procTab[i].pid);
      renderString(pidString, BOX_GENERAL, 3);
    }
  }
}
// Render a string to a graphical textbox.
void renderString(char* text, int boxID, int length){
  for( int i = 0; i < length; i++ ) {
    
    if(textBoxes[boxID].cursorX + (textBoxes[boxID].spacing * textBoxes[boxID].fontSize ) > textBoxes[boxID].width || text[i] == '\n'){
      textBoxes[boxID].cursorX = 0;
      textBoxes[boxID].cursorY += textBoxes[boxID].spacing * textBoxes[boxID].fontSize;
    }
    
    if(text[i] != '\n'){
      renderChar(basicFont8x8[text[i]], textBoxes[boxID].cursorY + textBoxes[boxID].posY, textBoxes[boxID].cursorX + textBoxes[boxID].posX , textBoxes[boxID].fontSize);
      addCharToTextboxBuffer(boxID, text[i]);
      textBoxes[boxID].cursorX += textBoxes[boxID].spacing * textBoxes[boxID].fontSize;
    }
    if(textBoxes[boxID].cursorY >= textBoxes[boxID].height){
      resetTextBox(boxID);
    }

    
  }
}
// Removes the most recent character in a textbox. Backspace.
void removeChar(int boxID, int length){
    int letterSize = (textBoxes[boxID].spacing * textBoxes[boxID].fontSize );
    for( int i = 0; i < length; i++ ) {
      
      if(textBoxes[boxID].text[0]!= 0 ){
        //remove a cursor
        renderChar(basicFont8x8[PS2_KEY_SPACE], (textBoxes[boxID].cursorY +  textBoxes[boxID].posY), (textBoxes[boxID].cursorX + textBoxes[boxID].posX), textBoxes[boxID].fontSize);
        
        if(textBoxes[boxID].cursorX - letterSize < -(letterSize) + 1){
          textBoxes[boxID].cursorX = textBoxes[boxID].width - (textBoxes[boxID].spacing * textBoxes[boxID].fontSize );
          if(cursorY != 0){
            textBoxes[boxID].cursorY -= textBoxes[boxID].spacing * textBoxes[boxID].fontSize;
            if(textBoxes[boxID].cursorY < 0){
              textBoxes[boxID].cursorY = 0;
              textBoxes[boxID].cursorX = textBoxes[boxID].spacing * textBoxes[boxID].fontSize;
            }
          }
          
        }
        textBoxes[boxID].cursorX -= textBoxes[boxID].spacing * textBoxes[boxID].fontSize;
        renderChar(basicFont8x8[PS2_KEY_SPACE], textBoxes[boxID].cursorY + textBoxes[boxID].posY, textBoxes[boxID].cursorX + textBoxes[boxID].posX , textBoxes[boxID].fontSize);
        removeCharFromTextboxBuffer(boxID);
        
      }
  }
}
// Clears a textbox
void resetTextBox(int boxID){
 // memset(textBoxes[boxID].text, 0, MAX_TEXT * sizeof(char));
  for(int a = 0; a < MAX_TEXT; a++){
    textBoxes[boxID].text[a] = 0;
  }
  for(int i = textBoxes[boxID].posY; i < textBoxes[boxID].height + textBoxes[boxID].posY; i++){
    for(int j = textBoxes[boxID].posX; j < textBoxes[boxID].width + textBoxes[boxID].posX; j++){
      fb[i][j] = 0;
    }
  }
  textBoxes[boxID].cursorX = 0;
  textBoxes[boxID].cursorY = 0;
}
// Take text from the graphical display and send it to the graphical console program. 
void sendCommandToBuffer(){

   // make a channel to pid 1 to send the command info

   procTab[0].ipc.receiving = true;
   
      // Pressed enter - send command info to console
    memset(cmdBuffer, 0, 64 * sizeof(char));
    for(int i = 0; i < MAX_TEXT; i++){

        addCharToCommandBuffer(textBoxes[BOX_COMMAND].text[i]);
      
      
    }
    addCharToCommandBuffer('\n');
    // Now clear what has been written in the command box
      if(checkBuffer(2) != SEM_FULL){
          // send the command buffer contents to the console
          for(int i = 0; i < MAX_TEXT; i++){
            //if(cmdBuffer[i] != 0){
              send(2, cmdBuffer[i]);
              //putstring("s", 1);
          //  } 
            
          }
        }
}
// SImple PS/2 raw input controller
void keyboardController(uint8_t x){
  
  if(x == PS2_KC_BS && !blockNext){
    
    
    removeChar(BOX_COMMAND, 1);
    blockNext = false;
  }
  
  else if(x != 0xF0 && !blockNext && x != PS2_SHIFT){
    int asciiCode = 0;
    // get real key
    for(int i = 0; i < 111; i++){
      if(single_key[i][0] == x) asciiCode = single_key[i][1];
    }
    // if the real key is a legal character
    if(asciiCode > 30) renderString(&asciiCode, BOX_COMMAND, 1);
   
    blockNext = false;
  }
  else if(x == 0xF0){
    blockNext = true;
  }

  //backspace

  else if(x == PS2_KC_KP_ENTER){
    if(textBoxes[BOX_COMMAND].text[0] != 0 ){
      sendCommandToBuffer();
      resetTextBox(BOX_COMMAND);
      blockNext = false;
    }

  }
  else{
    blockNext = false;
  }
}
/// End of LCD




void dispatch( ctx_t* ctx, pcb_t* prev, pcb_t* next ) {
  char prev_pid = '?', next_pid = '?';
  
  if( NULL != prev ) {
    memcpy( &prev->ctx, ctx, sizeof( ctx_t ) ); // preserve execution context of P_{prev}
    prev_pid = '0' + prev->pid;
  }
  if( NULL != next ) {
    memcpy( ctx, &next->ctx, sizeof( ctx_t ) ); // restore  execution context of P_{next}
    next_pid = '0' + next->pid;
  }


    executing = next;                           // update   executing process to P_{next}

  return;
}

void schedule( ctx_t* ctx ) {
  uint32_t maxPriority = 0;
  currentProcessStackPos = 0;
  maxPriorityProcessID = 0;
  // Choose a process


  // For each process, if it is not executing, add one to the priority.
  // Update the process state 
  for (int n = 0; n < currentProcs; n++){
    // If the process is currently executing
    if(procTab[n].status == STATUS_EXECUTING && procTab[n].full == true){
      currentProcessStackPos = n;
      procTab[n].status = STATUS_READY;
      procTab[n].priority  = procTab[n].priority_base;
      
    }
    // If the ready processes have their priority increased is currently executing
    else if(procTab[n].status == STATUS_READY && procTab[n].full == true){
      procTab[n].priority  = procTab[n].priority + 1;
    }
  }

  // Find max priority

  for (int n = 0; n < currentProcs; n++){
    if(procTab[n].priority > maxPriority){
      maxPriority = procTab[n].priority;
      maxPriorityProcessID = n;
    } 
  }
  currentProcessID = procTab[maxPriorityProcessID].pid;
  // Dispatch the process
    dispatch(ctx, &procTab[ currentProcessStackPos ], &procTab[ maxPriorityProcessID ] );
    procTab[maxPriorityProcessID].status = STATUS_EXECUTING;
    currentProcessStackPos = maxPriorityProcessID;
    return;
}
// Convert a pid to a position in the memory stack
int pidToStackPos(int id){
  for (int i = 0; i < MAX_PROCS; i++){
    if(procTab[i].pid == id){
      return i;
    }
  }
  return 0;
}
extern uint32_t tos_ProgramsStack;

extern void     main_console(); 
 

// Set a process' program counter to an actual program and validate process.
void executeProcess(int stackPosition, uint32_t ctx_pc){
   // memset( &procTab[ stackPosition ], 0, sizeof( pcb_t ) ); 
    int stackOffset = stackSize / MAX_PROCS;
    procTab[ stackPosition ].status   = STATUS_READY;
    procTab[ stackPosition ].ctx.pc   = ctx_pc;
}
// Used in fork. Set a the details of a process to that of a parentID.
void setProcessInfo(int stackPosition, uint32_t ctx_pc, uint32_t parentID, uint32_t priority, int processID){
    memset( &procTab[ stackPosition ], 0, sizeof( pcb_t ) ); 
    int stackOffset = stackSize / MAX_PROCS;
    procTab[ stackPosition ].pid      = processID;
    procTab[ stackPosition ].status   = STATUS_READY;
    procTab[ stackPosition ].tos      = ( uint32_t )( &tos_ProgramsStack  + stackOffset * stackPosition); // Add the top of stack to the offset
    procTab[ stackPosition ].ctx.cpsr = 0x50;
    procTab[ stackPosition ].ctx.pc   = ctx_pc;
    procTab[ stackPosition ].ctx.sp   = procTab[stackPosition].tos;
    procTab[ stackPosition ].priority = priority;
    procTab[ stackPosition ].parentPid = parentID;
    procTab[stackPosition].full = true;
    procTab[stackPosition].ipc.emptyCount = MAX_QUEUE;
    procTab[stackPosition].ipc.fullCount  = 0;
    procTab[stackPosition].ipc = procTab[stackPosition].ipc;
}
// Validate and reset a process
void processReset(int stackPosition, int processID){
    memset( &procTab[ stackPosition ], 0, sizeof( pcb_t ) ); 
    int stackOffset = stackSize / MAX_PROCS;
    procTab[ stackPosition ].pid      = processID;
    procTab[ stackPosition ].status   = STATUS_READY;
    procTab[ stackPosition ].tos      = ( uint32_t )( &tos_ProgramsStack  + stackOffset * stackPosition); // Add the top of stack to the offset
    procTab[ stackPosition ].ctx.cpsr = 0x50;
   // procTab[ i ].ctx.pc   = ctx_pc;
   // procTab[ stackPosition ].ctx.sp   = procTab[stackPosition].tos;
    procTab[ stackPosition ].priority = 0;
    procTab[stackPosition].full = true;
    procTab[stackPosition].ipc = procTab[stackPosition].ipc;
   // procTab[ i ].parentPid = 0;
}
// Draw a rectangle to the LCD
void drawRect(int posY, int posX, int height, int width){
  for(int y = posY; y < (posY + height); y++){
    fb[y][posX] = 200;
    fb[y][posX + width] = 200;
  }
  for(int x = posX; x < (posX + width); x++){
    fb[posY][x] = 200;
    fb[posY+height][x] = 200;
  }
}
// Removes a rectangle from LCD
void clearRect(int posY, int posX, int height, int width, bool dotted){
  for(int y = posY; y <= (posY + height); y++){
    fb[y][posX] = 0;
    fb[y][posX + width] = 0;
  }
  for(int x = posX; x <= (posX + width); x++){
    fb[posY][x] = 0;
    fb[posY+height][x] = 0;
  }
  
}
// Initialises the positions for the default set of textboxes. May be increased via programs (later if it's implemented, this code is getting big)
void initTextBoxes(){
      for(int i = 0; i < MAX_WINDOWS; i ++){
   // textBoxes[i].cursorX = 0;
   // textBoxes[i].cursorY = 0;
    textBoxes[i].spacing = 10;
  }
  // Title
  textBoxes[0].height = 100;
  textBoxes[0].width = 700;
  textBoxes[0].posX = 150;
  textBoxes[0].posY = 10;
  textBoxes[0].fontSize = 8;
  
  

  // Command Box
  textBoxes[1].height = 30;
  textBoxes[1].width = 300;
  textBoxes[1].posX = 50;
  textBoxes[1].posY = 110;
  textBoxes[1].fontSize = 2;
  // Dotted Outline
  
  // Output Box
  textBoxes[2].height = 350;
  textBoxes[2].width = 300;
  textBoxes[2].posX = 50;
  textBoxes[2].posY = 150;
  textBoxes[2].fontSize = 1;
 // drawRect(150, 50, 200, 300, true);
  // Process Box
  textBoxes[3].height = 180;
  textBoxes[3].width = 200;
  textBoxes[3].posX = 500;
  textBoxes[3].posY = 110;
  textBoxes[3].fontSize = 1;
 // drawRect(100, 500, 300, 200);
    // Image Box
  textBoxes[4].spacing = 7;
  textBoxes[4].height = 330;
  textBoxes[4].width = 290;
  textBoxes[4].posX = 400;
  textBoxes[4].posY = 350;
  textBoxes[4].fontSize = 1;
}

// Sets the parameters for the LCD output display. 
void lcdReset(){
    // Configure the LCD display into 800x600 SVGA @ 36MHz resolution.

  SYSCONF->CLCD      = 0x2CAC;     // per per Table 4.3 of datasheet
  LCD->LCDTiming0    = 0x1313A4C4; // per per Table 4.3 of datasheet
  LCD->LCDTiming1    = 0x0505F657; // per per Table 4.3 of datasheet


  LCD->LCDTiming2    = 0x071F1800; // per per Table 4.3 of datasheet

  LCD->LCDUPBASE     = ( uint32_t )( &fb );

  LCD->LCDControl    = 0x00000020; // select TFT   display type
  LCD->LCDControl   |= 0x00000008; // select 16BPP display mode
  LCD->LCDControl   |= 0x00000800; // power-on LCD controller
  LCD->LCDControl   |= 0x00000001; // enable   LCD controller

  /* Configure the mechanism for interrupt handling by
   *
   * - configuring then enabling PS/2 controllers st. an interrupt is
   *   raised every time a byte is subsequently received,
   * - configuring GIC st. the selected interrupts are forwarded to the 
   *   processor via the IRQ interrupt signal, then
   * - enabling IRQ interrupts.
   */

  PS20->CR           = 0x00000010; // enable PS/2    (Rx) interrupt
  PS20->CR          |= 0x00000004; // enable PS/2 (Tx+Rx)
 // PS21->CR           = 0x00000010; // enable PS/2    (Rx) interrupt
 // PS21->CR          |= 0x00000004; // enable PS/2 (Tx+Rx)

  uint8_t ack;

        PL050_putc( PS20, 0xF4 );  // transmit PS/2 enable command
  ack = PL050_getc( PS20       );  // receive  PS/2 acknowledgement
  //        PL050_putc( PS21, 0xF4 );  // transmit PS/2 enable command
  //  ack = PL050_getc( PS21       );  // receive  PS/2 acknowledgement

  GICC0->PMR         = 0x000000F0; // unmask all          interrupts
  GICD0->ISENABLER1 |= 0x00300000; // enable PS2          interrupts
  //GICC0->CTLR        = 0x00000001; // enable GIC interface
  //GICD0->CTLR        = 0x00000001; // enable GIC distributor

  initTextBoxes();
  renderString("GLaDOS", BOX_TITLE, 6);

  
}

// Resets the PCB and calls to reset the LCD display.
void hilevel_handler_rst( ctx_t* ctx              ) { 
  
  // gets all our program functions in an array
  /* Invalidate all entries in the process table, so it's clear they are not
   * representing valid (i.e., active) processes.
   */

  // all processes are now invalid
  for( int i = 0; i < currentProcs; i++ ) {
    procTab[ i ].status = STATUS_INVALID;
    procTab[ i ].full = false;
  }



  // Calculate the current size of the stack:
  
  // Find the size of the stack offset
 
  // TODO - get a list of program pointers.
  setProcessInfo(0, (uint32_t)(&main_console), 0, 5, 1);
  for( int i = 1; i < currentProcs; i++ ) {
    // populates the pcbs of the processes we are holding
    processReset(i, procTab[ i ].pid);
  }
  

  /* Once the PCBs are initialised, we arbitrarily select the 0-th PCB to be 
   * executed: there is no need to preserve the execution context, since it 
   * is invalid on reset (i.e., no process was previously executing).
   */

  TIMER0->Timer1Load  = 0x00010000; // select period = 2^20 ticks ~= 1 sec
  TIMER0->Timer1Ctrl  = 0x00000002; // select 32-bit   timer
  TIMER0->Timer1Ctrl |= 0x00000040; // select periodic timer
  TIMER0->Timer1Ctrl |= 0x00000020; // enable          timer interrupt
  TIMER0->Timer1Ctrl |= 0x00000080; // enable          timer

  lcdReset();
  GICC0->PMR          = 0x000000F0; // unmask all            interrupts
  GICD0->ISENABLER1  |= 0x00000010; // enable timer          interrupt
  GICC0->CTLR         = 0x00000001; // enable GIC interface
  GICD0->CTLR         = 0x00000001; // enable GIC distributor

  
  int_enable_irq();

  dispatch( ctx, NULL, &procTab[ 0 ] );
  
  return;
}
// Displays a blinking cursor in the command box in the graphical UI.
void cursorCommand(){
  write( STDOUT_FILENO, "-", 1 );
       if(cursor){
         renderChar(basicFont8x8['_'], (textBoxes[BOX_COMMAND].cursorY +  textBoxes[BOX_COMMAND].posY), (textBoxes[BOX_COMMAND].cursorX + textBoxes[BOX_COMMAND].posX), textBoxes[BOX_COMMAND].fontSize);
         cursor = false;
       }
       else{
         renderChar(basicFont8x8[' '], (textBoxes[BOX_COMMAND].cursorY +  textBoxes[BOX_COMMAND].posY), (textBoxes[BOX_COMMAND].cursorX + textBoxes[BOX_COMMAND].posX), textBoxes[BOX_COMMAND].fontSize);
         cursor = true;
       }
}
// Takes timer and keyboard interrupts. Mouse interrupts seem to crash the kernel. I don't know why.
void hilevel_handler_irq(ctx_t* ctx) {
  // Step 2: read  the interrupt identifier so we know the source.

  uint32_t id = GICC0->IAR;
  uint8_t input;
  // Step 4: handle the interrupt, then clear (or reset) the source.

  switch (id)
  {
  case GIC_SOURCE_TIMER0:

       cursorCommand();
       
       schedule(ctx);
       TIMER0->Timer1IntClr = 0x01;        
       GIC_SOURCE_UART0;
       break;    
    break;
  
  case GIC_SOURCE_PS20:
      
      input =  PL050_getc( PS20 );
      keyboardController(input); 
            
      
    break; 
  
  case GIC_SOURCE_PS21:
    //  uint8_t input = PL050_getc( PS21 );

      /*PL011_putc( UART0, '1',                      true );  
      PL011_putc( UART0, '<',                      true ); 
      PL011_putc( UART0, itox( ( x >> 4 ) & 0xF ), true ); 
      PL011_putc( UART0, itox( ( x >> 0 ) & 0xF ), true ); 
      
      PL011_putc( UART0, '>',                      true ); 
      PL011_putc( UART0, ' ',                      true );
      PL011_putc( UART0, ' ',                      true ); 
      PL011_putc( UART0, ' ',                      true );  
      PL011_putc( UART0, ' ',                      true ); 
      PL011_putc( UART0, ' ',                      true ); 
      PL011_putc( UART0, ' ',                      true ); 
      PL011_putc( UART0, ' ',                      true ); 
      PL011_putc( UART0, ' ',                      true ); 
      // now render a letter at position
    // renderString("<>", )
    */
    break; 
  default:
    break;
  }





  // Step 5: write the interrupt identifier to signal we're done.

  GICC0->EOIR = id;

  return;
}

// Removes a process from the process table, designated by a pid.
// Once a process has been removed, all higher processes in the stack are moved down to reclaim its space.
// This way, we do not have to worry about finding empty positions in the stack, since the stack will always be in order.
void removeProcess(ctx_t* ctx, int procReference){
      
      int terminateID = 0;
      int terminateStackPos = 0;
      // Find the correct process
      for( int i = 0; i < MAX_PROCS; i++ ) {
        if(procTab[i].pid == procReference){ 
          putstring("FOUND", 5);
          terminateID = procTab[i].pid;
          terminateStackPos= i;
        }
      }
      if(terminateStackPos == 0){return;}
      for( int i = terminateStackPos; i < MAX_PROCS; i++ ) {
          procTab[i].parentPid = procTab[i+1].parentPid;
          int stackOffset = stackSize / MAX_PROCS;
          procTab[ i ].pid      = procTab[i+1].pid;
          procTab[ i ].ctx.pc   = procTab[ i+1 ].ctx.pc;
          procTab[ i ].priority = procTab[ i + 1].priority;
          procTab[ i ].parentPid = procTab[ i + 1].parentPid;
          int tos = procTab[i].tos;
          procTab[ i ].ctx = procTab[i+1].ctx;
          procTab[ i ].ctx.sp = procTab[i+1].ctx.sp - stackOffset;
          procTab[i].status = procTab[i+1].status;
          procTab[i].ipc = procTab[i+1].ipc;
          memcpy( (uint32_t) procTab[i].tos, (uint32_t) procTab[i+1].tos, sizeof( stackOffset ) ); 
          memset( (uint32_t) procTab[i+1].tos, 0, sizeof( stackOffset ) ); 
      }
      memset( &procTab[ currentProcs ], 0, sizeof( pcb_t ) ); 
      procTab[currentProcs].full = false;
      // Reduce current processes by one
      currentProcs --;
      graphicWrite(BOX_OUTPUT, "\nPROCESS REMOVED\n", 18);
}

bool checkSemaphoreFree(int procStackPos){
       for( int i = 0; i < MAX_QUEUE; i++ ) {
        if(procTab[procStackPos].ipc.semaphoreQueue[i] == 0){
            return true; 
        }
     }
     return false;
}
bool checkSemaphoreEmpty(int procStackPos){
       for( int i = 0; i < MAX_QUEUE; i++ ) {
        if(procTab[procStackPos].ipc.semaphoreQueue[i] != 0){
            return false; 
        }
     }
     return true;
}

// Adds an element to a process' receive queue. Process will read these values
void addToSemaphoreQueue(int procStackPos, char data){
  
      for( int i = 0; i < MAX_QUEUE; i++ ) {
        if(procTab[procStackPos].ipc.semaphoreQueue[i] == 0){
            procTab[procStackPos].ipc.semaphoreQueue[i] = data;
         //   graphicWrite(BOX_OUTPUT, " add ", 5);
            return;
        }
      }
      return;
}

// Add a process id to a broadcast buffer, facilitating 1 - many IPC communication
void addToPidBuffer(int procStackPos, int pid1){
      for( int i = 0; i < MAX_QUEUE; i++ ) {
        if(procTab[procStackPos].ipc.broadcastPidBuffer[i] == 0){
            procTab[procStackPos].ipc.broadcastPidBuffer[i] = pid1;
            putstring("SUC", 3);
            return;
        }
      }
      return;
}

// returns the head of the semaphore queue if non empty.
int removeFromSemaphoreQueue(int procStackPos){
 // graphicWrite(BOX_OUTPUT, " remCall\n ", 11);
//  write(BOX_OUTPUT, " remCall ", 10);
  int data = 0;
  bool removed = false;
      for( int i = 0; i < MAX_QUEUE; i++ ) {
        if(procTab[procStackPos].ipc.semaphoreQueue[i] != 0 && removed == false){
            data = procTab[procStackPos].ipc.semaphoreQueue[i];
          //  putstring("REM", 3);
            // shuffle all other values forward
            for( int j = i; j < MAX_QUEUE; j++ ) {
              procTab[procStackPos].ipc.semaphoreQueue[j] = procTab[procStackPos].ipc.semaphoreQueue[j + 1];
            }
            procTab[procStackPos].ipc.semaphoreQueue[MAX_QUEUE] = 0;
            removed = true;
        //    write( STDOUT_FILENO, "read", 5 );
        }
      }
      return data;
}

// returns the head of the semaphore queue if non empty.
int removeFromBufferQueue(int procStackPos){
  int data = 0;

  bool removed = false;
      for( int i = 0; i < MAX_QUEUE; i++ ) {
        if(procTab[procStackPos].ipc.broadcastPidBuffer[i] != 0 && removed == false){
            data = procTab[procStackPos].ipc.broadcastPidBuffer[i];
          //  putstring("REMb", 4);
            // shuffle all other values forward
            for( int j = i; j < MAX_QUEUE; j++ ) {
              procTab[procStackPos].ipc.broadcastPidBuffer[j] = procTab[procStackPos].ipc.broadcastPidBuffer[j + 1];
            }
            procTab[procStackPos].ipc.broadcastPidBuffer[MAX_QUEUE] = 0;
            removed = true;
            return data;
        }
      }
      return data;
}


// Safely increases a semaphore value
int up(int value){
  if(value + 1 <= MAX_QUEUE){
    value += 1;
    return value;
  }
  else{
    return value;
  }
}

// Safely reduces a semaphore value
int down(int value){
  if(value - 1 >= 0){
    value -= 1;
    return value;
  }
  else{
    return value;
  }
}


// Services Interrupt
void hilevel_handler_svc( ctx_t* ctx, uint32_t id ) { 
  /* Based on the identifier (i.e., the immediate operand) extracted from the
   * svc instruction, 
   *
   * - read  the arguments from preserved usr mode registers,
   * - perform whatever is appropriate for this system call, then
   * - write any return value back to preserved usr mode registers.
   */

  switch( id ) {
    // Yields control of the scheduler
    case SYS_YIELD : { // 0x00 => yield()

      schedule( ctx );

      break;
    }
    // Writes a string to console.
    case SYS_WRITE : { // 0x01 => write( fd, x, n )
      int   fd = ( int   )( ctx->gpr[ 0 ] );  
      char*  x = ( char* )( ctx->gpr[ 1 ] );  
      int    n = ( int   )( ctx->gpr[ 2 ] ); 

      for( int i = 0; i < n; i++ ) {
        PL011_putc( UART0, *x++, true );
      }
      
      ctx->gpr[ 0 ] = n;

      break;
    }

    // Duplicates the currently running process and adds it to the pcb. Stack meta information is updated.
    case SYS_FORK : { // this is FORK
      int   progReference = ( int   )( ctx->gpr[ 0 ] );
      if(currentProcs < MAX_PROCS){
        // Make a new process.
        int newProcessID = highestProcessID + 1;
        int newStackPosition = 0;
        uint32_t newProgramPointer = procTab[ currentProcessStackPos ].ctx.pc;
        // TODO - change first argument to be the first free program in the PCB

        // loop through process table. Find first free.
        for( int i = 0; i < MAX_PROCS; i++ ) {
          if(procTab[i].full == false || procTab[i].full == NULL){
               newStackPosition = i; // kyuudukfdytdytdytdytdytdthd
             }
        }

        setProcessInfo(currentProcs, (uint32_t) newProgramPointer, currentProcessID, 1, newProcessID);
        // now we need to copy the program stack
        memcpy( (uint32_t) procTab[newProcessID].tos, (uint32_t) procTab[currentProcessStackPos].tos, sizeof( stackSize / MAX_PROCS ) ); 

        char pidString[3];
        itoa(pidString, newProcessID);

        
        ctx->gpr[0] = 0;
      }
      break;
    }
    // Safely exits and terminates a process. Called from its own program.
    case SYS_EXIT : { // this is EXIT
      putstring("EXIT", 4);
      // Get the parent of the current process.
      // Wait until its turn.
      // Remove process on yield of parent
      int parentID = procTab[pidToStackPos(currentProcessID)].parentPid;
      int parentStackPos = pidToStackPos(parentID);
      int myPos = pidToStackPos(currentProcessID);
      removeProcess(ctx, currentProcessID);
      dispatch(ctx, &procTab[ myPos ], &procTab[ parentStackPos ] );
      procTab[parentStackPos].status = STATUS_EXECUTING;
      displayPids();
      

     // currentProcessStackPos = parentStackPos;
      break;
    }
    // Executes a process
    case SYS_EXEC : { // this is EXEC
      
      int   progReference = ( int   )( ctx->gpr[ 0 ] );
      highestProcessID += 1;
      executeProcess(currentProcs, (uint32_t) progReference);
      currentProcs += 1;
      displayPids();
      break;
    }
    // Hard removes a process.
    case SYS_KILL : { // this is KILL
      putstring("KILL", 4);
      uint32_t   procReference = ( int   )( ctx->gpr[ 0 ] );
      removeProcess(ctx, procReference);
      putstring("SUCC", 4);
      displayPids();
      break;
    }
    // Sets the base priority of a process
    case SYS_NICE : { // this is NICE
      putstring("NICE", 4);

      
      uint32_t   pid = ( int   )( ctx->gpr[ 0 ] );
      uint32_t   value = ( int   )( ctx->gpr[ 1 ] );
      int stackPos = pidToStackPos(pid);
      procTab[stackPos].priority_base = value;
      break;
    }

    // System calls sends an item of data to a process designated by pid.
    case SYS_SEND : { 
      uint32_t   pid = ( int   )( ctx->gpr[ 0 ] );
      uint32_t   data = ( char   )( ctx->gpr[ 1 ] );
      // PRODUCER CONSUMER STYLE
      int receiveStackpos = pidToStackPos(pid);
      if(procTab[receiveStackpos].ipc.mutexLocked == false){
        // empty semaphore
        procTab[receiveStackpos].ipc.emptyCount = down(procTab[receiveStackpos].ipc.emptyCount);
        // Mutex lock
        procTab[receiveStackpos].ipc.mutexLocked = true;
        // Add to receive queue of process
        addToSemaphoreQueue(receiveStackpos, data);
        // mutex unlock
        procTab[receiveStackpos].ipc.mutexLocked = false;
        // full semaphore
        procTab[receiveStackpos].ipc.fullCount = up(procTab[receiveStackpos].ipc.fullCount);
      }
      break;
    }
    // Checks if an IPC channel is empty and returns an int. 0 if empty, 1 if partially filled, 2 if full.
    case SYS_CHECK : { 
     // Special case with argument r=0. Just check the current process

     // check the semaphore queue of the specified pid.
     // if there is room, then return true via gpr r0
     uint32_t   pid = ( int   )( ctx->gpr[ 0 ] );
     int procStackPos = 0;
     if(pid == 0){
       procStackPos = currentProcessStackPos;
     }
     else{
       procStackPos = pidToStackPos(pid);
     }
     
     if(checkSemaphoreEmpty(procStackPos) && procTab[procStackPos].ipc.mutexLocked == false){
       ctx->gpr[0] = 0;
     }
     else if(checkSemaphoreFree(procStackPos) && procTab[procStackPos].ipc.mutexLocked == false){
       ctx->gpr[0] = 1;
     }


     else{
       ctx->gpr[0] = 2;
     }
      break;
    }
    // Given a pid, read the last element of a process' semaphore queue, then remove it.
    case SYS_SEMREAD : { 

      uint32_t   pid = ( int   )( ctx->gpr[ 0 ] );
      int readStackPos = 0;
      if(pid == 0){
         readStackPos = currentProcessStackPos;
      }
      else{
         readStackPos = pidToStackPos(pid);
      }
      
      int data = 0;
      // Read data from pipe x.
      // Remove it from queue once read
        down(procTab[readStackPos].ipc.fullCount);
        procTab[readStackPos].ipc.mutexLocked = true;
        data = removeFromSemaphoreQueue(readStackPos);
        procTab[readStackPos].ipc.mutexLocked = false;
        up(procTab[readStackPos].ipc.emptyCount);

      // Return the next data value
      ctx->gpr[0] = data;
      break;
    }

    //  Facilitates handshaking between a send and receive process.
    //  Given a positive source pid; add or remove a recipient process from its broadcast buffer
    case SYS_MAKECHANNEL : { 
      int   pidSource = ( int   )( ctx->gpr[ 0 ] );
      int   pidDest = ( int   )( ctx->gpr[ 1 ] );

      

      int sourceStackPos = pidToStackPos(pidSource);
      // Send a negative destination to remove channel
      procTab[pidToStackPos(pidDest)].ipc.receiving = true;
      addToPidBuffer(sourceStackPos, pidDest);
      // if pidDest is negative then flush the channel
      if(pidDest<0){
        pidDest*=-1;
        procTab[pidToStackPos(pidDest)].ipc.receiving = false;
        for (size_t i = 0; i < MAX_QUEUE; i++)
        {
          procTab[pidToStackPos(pidDest)].ipc.semaphoreQueue[i] = 0;
        }
      }
      int success = 1;
      ctx->gpr[0] = success;
      break;
    }
    // A specialised control channel system call. Allows for 1 - many inter-process communication.
    // Called by a currently running process to add or remove recipient processes from its send channels.
    case SYS_CHANNELCONTROLLER : { 
      int recStackPos = currentProcessStackPos;
      int request = 0;
      
      // return the pid of the request. Positive value if send, negative if remove.
      request = removeFromBufferQueue(recStackPos);
      

      
      ctx->gpr[0] = request;
      break;
    }

    // Requests the pid of the currently executing process
    case SYS_REQPID : {
      ctx->gpr[0] = currentProcessID;
      break;
    }

    // Similar to SYS_WRITE, but writes to the graphical console
    case SYS_WRITE_GRAPHIC : {
      int   box = ( int   )( ctx->gpr[ 0 ] );  
      char*  x = ( char* )( ctx->gpr[ 1 ] );  
      int    n = ( int   )( ctx->gpr[ 2 ] ); 
      
      for( int i = 0; i < n; i++ ) {
        renderString(&x[i], box, 1);
      //  PL011_putc( UART0, *x++, true );
      }
      break;
    }

    // Allows a program to draw a rectangle to the LCD display
    case SYS_DRAW_RECT:{
      int   y = ( int   )( ctx->gpr[ 0 ] ); 
      int   x = ( int   )( ctx->gpr[ 1 ] ); 
      int   height = ( int   )( ctx->gpr[ 2 ] ); 
      int   width = ( int   )( ctx->gpr[ 3 ] ); 
      drawRect(y, x, height, width);
      break;
    }

    default   : { // 0x?? => unknown/unsupported
      break;
    }
  }

  return;
}
