#include "P5.h"

char lyrics[1530] = "This Was a Triumph\nI'm making a note here:\nHUGE SUCCESS\nIt's hard to overstate\nMy satisfaction.\n\nAperture Science\nWe do what we must because we can\nFor the good of all of us\nExcept the ones who are dead.\nBut there's no sense cyring over every mistake\nYou just keep on trying till you run out of cake\nAnd the Science gets done, and you make a neat gun\nFor the people who are still alive\n\nI'm not even angry\nI'm being so sincere right now\nEven though you broke my heart and killed me\n\nAnd tore me to pieces\nAnd threw every piece into a fire\nAs they burned it hurt because\nI was so happy for you\n\nNow theseNow these points of data make a beautiful line\nAnd we're out of beta, we're releasing on time\nSo I'm GLaD I got burned; think of all the things we learned\nFor the people who are still alive\nGo ahead and leave me\nI think I prefer to stay inside\nMaybe you'll find someone else to help you\n\nMaybe Black Mesa\nThat was a joke. Haha, fat chance\nAnyway this cake is great\nIt's so delicious and moist\n\nLook at me still talking when there's Science to do\nWhen I look out there, it makes me GLaD I'm not you\nI've experiments to run; there is research to be done\nOn the people who are still alive\n\nPS: And believe me I am still alive\n\nPPS: I'm doing science and I'm still alive\n\nPPPS: I feel fantastic and I'm still alive\n\n\n\nFINAL THOUGHT:\nWhile you're dying I'll be still alive\n\nFINAL THOUGHT PS:\nAnd when you're dead I will be still alive.\n\n STILL ALIVE \n\n\n still alive...\n\n\n\n\n whoah crikey thanks for looking at the whole thing Dan :)" ;

void logo(){
  graphicWrite(BOX_IMAGE, "              .,-:;//;:=,\n", 26);
  graphicWrite(BOX_IMAGE, "         . :H@@@MM@M#H/.,+&;,\n", 30);
  graphicWrite(BOX_IMAGE, "       ,/X+ +M@@M@MM^=,-^HMMM@X/,\n", 34);
  graphicWrite(BOX_IMAGE, "     -+@MM; $M@@MH+-,;XDANM@MMMM@+-\n", 36);
  graphicWrite(BOX_IMAGE, "    ;@M@@M- XM@X;. -+XXXXXHHH@M@M#@/.\n", 38);
  graphicWrite(BOX_IMAGE, "  ,AMM@@MH ,@A=             .---=-=:=,.\n", 40);
  graphicWrite(BOX_IMAGE, "  =@#@@@MX.,                -AHX$$%%A:;\n", 40);
  graphicWrite(BOX_IMAGE, " =-./@M@M$                   .;@MMMM@MM:\n", 41);
  graphicWrite(BOX_IMAGE, " X@/ -$MM/                    . +MM@@@M$\n", 41);
  graphicWrite(BOX_IMAGE, ",@M@H: :@:                    . =X#@@@@-\n", 41);
  graphicWrite(BOX_IMAGE, ",@@@MMX, .                    /H- ;@M@M=\n", 41);
  graphicWrite(BOX_IMAGE, ".H@@@@M@+,                    AMM+..A#$.\n", 41);
  graphicWrite(BOX_IMAGE, " /MMMM@MMH/.                  XM@MH; =;\n", 40);
  graphicWrite(BOX_IMAGE, "  /%+%$XHH@$=              , .H@@@@MX,\n", 39);
  graphicWrite(BOX_IMAGE, "   .=--------.           -AH.,@@@@@MX,\n", 39);
  graphicWrite(BOX_IMAGE, "   .AMM@@@HHHXX$$$A+- .:$MMX =M@@MMA.\n", 38);
  graphicWrite(BOX_IMAGE, "     =XMMM@MM@MM#H;,-+HMM@M+ /MMMX=\n", 36);
  graphicWrite(BOX_IMAGE, "       =A@M@M#@$-.=$@MM@@@M; AAM=\n", 34);
  graphicWrite(BOX_IMAGE, "         ,:+$+-,/H#MMMDANM@= =,\n", 32);
  graphicWrite(BOX_IMAGE, "               =++%%%%+/:-.\n", 28);
}

void main_alive() {

  logo();
  for( int i = 0; i < 1530; i++ ) {
    write( STDOUT_FILENO, &lyrics[i], 1 );
    graphicWrite(BOX_OUTPUT, &lyrics[i], 1);
    for( int j = 0; j < 10000000; j++ ) {

    }
  }
  exit( EXIT_SUCCESS );
}