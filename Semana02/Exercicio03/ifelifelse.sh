#!/bin/bash

#${1,,} pega o primeiro positional argument e a expansao {1,,} serve para ignorar as letras maiusculas ou miniusculas
if [ ${1,,} = luis ]; then
    echo "oh, you're the boss"
elif [ ${1,,} = help ]; then
    echo "just enter your username"
else
    echo "I don't know who you are"
fi