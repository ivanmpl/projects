#!/usr/bin/env python3

import math

# calculate the distance of two points
def calculateDistance(x1,y1,x2,y2):
    dist = math.sqrt((x2 - x1)**2 + (y2 - y1)**2)
    return dist

# function to check x1,x2,y1,y2 coordinates to determine if corner of rectangle or square
def checkSquareCorner(x1,y1,x2,y2,x3,y3,x4,y4):
    side = calculateDistance(x1,y1,x2,y2)
    
    if(x1+side == x2):
        vertical = 1
    else if(x1-side == x2) :
        vertical = -1
    else:
        vertical = 0
        
    if(x1-side == x2):
        horizontal = 1
    else:
        horizontal = 0
        
    
    #side2 = calculateDistance(x2,y2,x3,y3)
    #side3 = calculateDistance(x3,y3,x4,y4)
    #side4 = calculateDistance(x4,y4,x1,x2)


    
    #print(side1,side2,side3,side4)


checkSquareCorner(1,1,1,10,10,10,10,1)
