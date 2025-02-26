#!/bin/bash

#Funções não possuem return usual. Elas apenas podem retornar valores numericos entre 0 a 255
#Esses valores representam o exit code da função, em que o valor zero é o valor retornado quando
#a função é executada sem problemas. A variavel $? acessa o exit code da ultima função executada
showname(){
    echo Hello $1
    if [ ${1,,} = luis ]; then
        return 0
    else
        return 1
    fi
    
}

showname $1
if [ $? = 1 ]; then
    echo "Alguem desconhecido chamou a função"
fi