package main

import (
	"fmt"
	"strconv"
	"strings"
	"time"
	)

func worker(height int,width int, c chan byte) {
    world := make([][]byte,height)
    for i :=range world {
        world[i] = make([]byte,width)
    }
    newWorld := make([][]byte,height-2)
        for i :=range newWorld {
            newWorld[i] = make([]byte,width)
        }
    for {
        for y:=0;y<height;y++ {
            for x:=0;x<width;x++ {
                world[y][x]=<-c
            }
        }


        for y := 1; y < height-1; y++ {
      		for x := 0; x < width; x++ {
      			// Placeholder for the actual Game of Life logic: flips alive cells to dead and dead cells to alive.
       			 var neighbors=0
       			 for i:=-1;i<2;i++ {
       			    for j:=-1;j<2;j++ {
                           if(i!=0 || j!=0) {
                               var yb=y+i
                               var xb=(x+j+width)%width
                               if(world[yb][xb]!=0){
                                   neighbors+=1
                               }
                           }
                       }
       			 }
                    if(neighbors==3){
                        newWorld[y-1][x] = 1
                    } else if(neighbors == 2) {
                        newWorld[y-1][x] = world[y][x]
                    } else {
                        newWorld[y-1][x] = 0
                    }
       	   	}
       	}


       	for y:=0;y<height-2;y++ {
            for x:=0;x<width;x++ {
                c<-newWorld[y][x]
            }
        }
    }
}

// distributor divides the work between workers and interacts with other goroutines.
func distributor(p golParams, d distributorChans, alive chan []cell) {

	// Create the 2D slice to store the world.
	world := make([][]byte, p.imageHeight)
	for i := range world {
		world[i] = make([]byte, p.imageWidth)
	}

    newWorld := make([][]byte, p.imageHeight)
    for i := range world {
    	newWorld[i] = make([]byte, p.imageWidth)
    }
    //currentKey := '0'
	// Request the io goroutine to read in the image with the given filename.
	d.io.command <- ioInput
	d.io.filename <- strings.Join([]string{strconv.Itoa(p.imageWidth), strconv.Itoa(p.imageHeight)}, "x")

    workerChannels := make([]chan byte,p.threads)
    for i := range workerChannels {
       workerChannels[i] = make(chan byte)
    }
    defaultHeight := p.imageHeight/p.threads
    height := make([]int, p.threads)

    for i,c:=range workerChannels {
        if(i!=p.threads-1) {
            height[i] = defaultHeight
        } else {
            height[i]=p.imageHeight-(defaultHeight*(p.threads-1))
        }
        go worker(height[i]+2,p.imageWidth,c)

    }


	// The io goroutine sends the requested image byte by byte, in rows.
	for y := 0; y < p.imageHeight; y++ {
		for x := 0; x < p.imageWidth; x++ {
			val := <-d.io.inputVal
			if val != 0 {
				fmt.Println("Alive cell at", x, y)
				world[y][x] = val
			}
		}
	}

	periodicChan := make(chan bool)
	go ticker(periodicChan)

    running := true
    paused := false
    aliveCount := 0
	// Calculate the new state of Game of Life after the given number of turns.
	for turns := 0; running&&(turns < p.turns); turns++ {

            for i,c:=range workerChannels {
                 if(i != p.threads-1) {
                    for y:=((i)*(defaultHeight)-1);y<((i+1)*(defaultHeight)+1);y++ {
                        for x:=0;x<p.imageWidth;x++ {
                            c<-world[(y+p.imageHeight)%p.imageHeight][x]
                        }
                    }
                 } else {
                    for y:=((i)*(defaultHeight)-1);y<(p.imageHeight+1);y++ {
                        for x:=0;x<p.imageWidth;x++ {
                            c<-world[(y+p.imageHeight)%p.imageHeight][x]
                        }
                    }
                 }

             }
             for i,c:=range workerChannels {
                 if(i != p.threads-1) {
                    for y:=((i)*(defaultHeight));y<((i+1)*(defaultHeight));y++ {
                        for x:=0;x<p.imageWidth;x++ {
                            newWorld[y][x]=<-c
                        }
                    }
                 } else {
                    for y:=((i)*(defaultHeight));y<(p.imageHeight);y++ {
                        for x:=0;x<p.imageWidth;x++ {
                            newWorld[y][x]=<-c
                        }
                    }
                 }
             }
             aliveCount = 0
             for y := 0; y < p.imageHeight; y++ {
                for x := 0; x < p.imageWidth; x++ {
                   world[y][x] = newWorld[y][x]
                   if(world[y][x] != 0) {
                       aliveCount+=1
                   }
                }
             }
             select {
                case <-periodicChan:
                fmt.Println(aliveCount)
                default:
             }
             select{
                 case currentKey := <-d.keyChan:
                     switch(currentKey) {
                         case 's':
                             printBoard(p,d,world)
                         case 'q':
                           //  printBoard(p,d,world)
                             running=false

                         case 'p':
                            paused=true
                            fmt.Println("PAUSED")
                            for (paused) {
                                currentKey2:=<-d.keyChan
                                switch(currentKey2){
                                    case 'p':paused = false
                                }
                            }
                            fmt.Println("UNPAUSED")
                     }
                 default:
        }


	}
        d.io.command <- ioOutput
        d.io.filename <- strings.Join([]string{strconv.Itoa(p.imageWidth), strconv.Itoa(p.imageHeight)}, "x")

        // Create an empty slice to store coordinates of cells that are still alive after p.turns are done.
        var finalAlive []cell
        // Go through the world and append the cells that are still alive.
        for y := 0; y < p.imageHeight; y++ {
            for x := 0; x < p.imageWidth; x++ {
                d.io.outputVal<-world[y][x]
                if world[y][x] != 0 {

                    finalAlive = append(finalAlive, cell{x: x, y: y})
                }

            }
        }

        // Make sure that the Io has finished any output before exiting.
        d.io.command <- ioCheckIdle
        <-d.io.idle

        // Return the coordinates of cells that are still alive.
        alive <- finalAlive

}

func ticker(aliveChan chan bool) {
    for{
        time.Sleep(2*time.Second)
        aliveChan<-true
    }
}

func printBoard(p golParams, d distributorChans,world[][]byte) {
    d.io.command <- ioOutput
    d.io.filename <- strings.Join([]string{strconv.Itoa(p.imageWidth), strconv.Itoa(p.imageHeight)}, "x")
    for y := 0; y < p.imageHeight; y++ {
        for x := 0; x < p.imageWidth; x++ {
       	    d.io.outputVal<-world[y][x]
       	}
    }
    d.io.command <- ioCheckIdle
    <-d.io.idle
}
