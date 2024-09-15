#!/bin/bash
# Verifica se dois parâmetros foram passados
if [ $# -ne 2 ]; then
  echo "Uso: $0 <numero1> <numero2>"
  exit 1
fi

# Atribui os parâmetros às variáveis
num1=$1
num2=$2

# Compara os números e exibe a relação
if [ $num1 -lt $num2 ]; then
  echo "$num1 é menor que $num2"
elif [ $num1 -gt $num2 ]; then
  echo "$num1 é maior que $num2"
else
  echo "$num1 é igual a $num2"
fi

