#!/bin/bash

array=(one two three four five)
for i in ${array[@]}
do
    echo -n $i | wc -c
done  