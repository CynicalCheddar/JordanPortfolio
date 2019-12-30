package main

import (
	"fmt"
	"strconv"
	"strings"
	)

func worker(height int,p golParams, c chan byte, aboveChan chan byte, belowChan chan byte, parity int) {
    world := make([][]byte,height)
    for i :=range world {
        world[i] = make([]byte,p.imageWidth)
    }
    newWorld := make([][]byte,height-2)
        for i :=range newWorld {
            newWorld[i] = make([]byte,p.imageWidth)
        }
    for y:=1;y<height-1;y++ {
                for x:=0;x<p.imageWidth;x++ {
                    world[y][x]=<-c
                }
            }
    for turns := 0; turns < p.turns; turns++ {
        if(parity == 1) {
                for x:=0;x<p.imageWidth;x++ {
                    belowChan<-world[height-2][x]
                }
                for x:=0;x<p.imageWidth;x++ {
                    world[0][x]=<-aboveChan
                }

                for x:=0;x<p.imageWidth;x++ {
                    aboveChan<-world[1][x]
                }
                for x:=0;x<p.imageWidth;x++ {
                    world[height-1][x]=<-belowChan
                }
        } else {

              for x:=0;x<p.imageWidth;x++ {
                    world[0][x]=<-aboveChan
                }
                for x:=0;x<p.imageWidth;x++ {
                    belowChan<-world[height-2][x]
                }
               for x:=0;x<p.imageWidth;x++ {
                    world[height-1][x]=<-belowChan
                }
                for x:=0;x<p.imageWidth;x++ {
                    aboveChan<-world[1][x]
                }

        }


        for y := 1; y < height-1; y++ {
      		for x := 0; x < p.imageWidth; x++ {
      			// Placeholder for the actual Game of Life logic: flips alive cells to dead and dead cells to alive.
       			 var neighbors=0
       			 for i:=-1;i<2;i++ {
       			    for j:=-1;j<2;j++ {
                           if(i!=0 || j!=0) {
                               var yb=y+i
                               var xb=(x+j+p.imageWidth)%p.imageWidth
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

       	for y:=1;y<height-1;y++ {
            for x:=0;x<p.imageWidth;x++ {
                world[y][x] = newWorld[y-1][x]
            }
        }


    }
    for y:=1;y<height-1;y++ {
        for x:=0;x<p.imageWidth;x++ {
            c<-world[y][x]
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
	// Request the io goroutine to read in the image with the given filename.
	d.io.command <- ioInput
	d.io.filename <- strings.Join([]string{strconv.Itoa(p.imageWidth), strconv.Itoa(p.imageHeight)}, "x")

    workerChannels := make([]chan byte,p.threads)
    haloChannels := make([]chan byte,p.threads)

    for i := range workerChannels {
       workerChannels[i] = make(chan byte)
       haloChannels[i] = make(chan byte)
    }
    defaultHeight := p.imageHeight/p.threads
    height := make([]int, p.threads)

    for i,c:=range workerChannels {
        if(i!=p.threads-1) {
            height[i] = defaultHeight
        } else {
            height[i]=p.imageHeight-(defaultHeight*(p.threads-1))
        }
        go worker(height[i]+2,p,c,haloChannels[(i-1+p.threads)%p.threads],haloChannels[i], i%2)
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
    for i,c:=range workerChannels {
        if(i != p.threads-1) {
            for y:=((i)*(defaultHeight));y<((i+1)*(defaultHeight));y++ {
                for x:=0;x<p.imageWidth;x++ {
                    c<-world[(y+p.imageHeight)%p.imageHeight][x]
                }
            }
        } else {
            for y:=((i)*(defaultHeight));y<(p.imageHeight);y++ {
                for x:=0;x<p.imageWidth;x++ {
                    c<-world[(y+p.imageHeight)%p.imageHeight][x]
                }
            }
        }
    }
	// Calculate the new state of Game of Life after the given number of turns.

    for i,c:=range workerChannels {
                 if(i != p.threads-1) {
                    for y:=((i)*(defaultHeight));y<((i+1)*(defaultHeight));y++ {
                        for x:=0;x<p.imageWidth;x++ {
                            world[y][x]=<-c
                        }
                    }
                 } else {
                    for y:=((i)*(defaultHeight));y<(p.imageHeight);y++ {
                        for x:=0;x<p.imageWidth;x++ {
                            world[y][x]=<-c
                        }
                    }
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

