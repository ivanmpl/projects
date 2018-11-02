#!/bin/bash

# Find all image files in current directory and process
file -i * | grep image | awk -F':' '{ print $1 }' | while 
read IMAGE
do
echo $IMAGE
NAME=`echo $IMAGE`
convert "$IMAGE" "${NAME}.pdf"
done
exit 0
