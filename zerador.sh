#!/bin/bash
# Verifica se um parametro foi passado
if [ $# -ne 1 ]; then
   echo "Uso: $0 <numero>"
   exit 1
fi


# Atribui o parametro a variavel
num=$1


# Loop para diminuir o numero ate zero
while [ $num -ge 0 ]; do
   echo -n "$num " # Exibe o numero na mesma linha
   num=$((num - 1)) # Diminui o numero
done
echo # Pula para a linha seguinte apos o loop
