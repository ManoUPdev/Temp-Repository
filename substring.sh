#!/bin/bash
# Verificar se dois parametros foram passados
if  [ $# -ne 2 ]; then
   echo "Uso: $0 <palavra1> <palavra2>"
   exit 1
fi

# Atribui os parametros as variaveis
str1=$1
str2=$2

# Verifica se a primeira string esta contida na segunda
if [[ $str2 == *$str1* ]]; then
   echo "$str1 está contida em $str2"
fi
