#!/bin/bash

up="before"
since="functions"

echo $up
echo $since

showuptime(){
    #Variaveis criadas normalmente dentro de funções são globais
    #EX:
    #up=$(uptime -p | cut -c4-)  
    #since=$(uptime -s)
    #Este caso rescreveria os valores das varias up="before" e since="functions"
    #Para defini-las localmente basta colocar local anteriormente a variavel como apresentado abaixo
    local up=$(uptime -p | cut -c4-)   
    local since=$(uptime -s)
    cat << EOF
-----
This machine has been up for ${up}
It has been running since ${since}
-----
EOF

echo This machine has been up for ${up} \
     It has been running since ${since}
}

showuptime

echo $up
echo $since