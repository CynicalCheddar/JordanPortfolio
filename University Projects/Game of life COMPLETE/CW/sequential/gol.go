package main

import (
	"fmt"
	"strconv"
	"strings"
)

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

	// Request the io goroutine to read in the image with the given filename.
	d.io.command <- ioInput
	d.io.filename <- strings.Join([]string{strconv.Itoa(p.imageWidth), strconv.Itoa(p.imageHeight)}, "x")

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
	// Calculate the new state of Game of Life after the given number of turns.
	for turns := 0; turns < p.turns; turns++ {
		for y := 0; y < p.imageHeight; y++ {
			for x := 0; x < p.imageWidth; x++ {
				// Placeholder for the actual Game of Life logic: flips alive cells to dead and dead cells to alive.
				 var neighbors=0
				 for i:=-1;i<2;i++ {
				    for j:=-1;j<2;j++ {
                        if(i!=0 || j!=0) {
                            var yb=((y+i+p.imageHeight)%p.imageHeight)
                            var xb=((x+j+p.imageWidth)%p.imageWidth)
                            if(world[yb][xb]!=0){
                                neighbors+=1
                            }
                        }
                    }
				 }
                if(neighbors==3){
                    newWorld[y][x] = 1
                } else if(neighbors == 2) {
                    newWorld[y][x] = world[y][x]
                } else {
                    newWorld[y][x] = 0
                }
			}
		}
		for y := 0; y < p.imageHeight; y++ {
        		for x := 0; x < p.imageWidth; x++ {
        		   world[y][x] = newWorld[y][x]
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
		    d.io.outputVal<-newWorld[y][x]
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
