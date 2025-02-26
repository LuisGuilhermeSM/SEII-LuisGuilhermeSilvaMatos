#!/bin/bash


case ${1,,} in
    luis | administrator) 
        echo "Hello, you're the boss" #o | serve como um operador or
        ;;
    help)
        echo "Just enter your username"
        ;;
    *)
        echo "i don't know who you are"
        ;;
esac