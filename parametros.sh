#!/bin/bash
# Verifica se pelo menos um parametro foi passado
if [ $# -eq 0 ]; then
   echo "Uso: $0 <parametro1> <parametro2> ... <parametroN>"
   exit 1
fi

# Contador para os parametros
contador=1

# Loop atraves de todos os parametros
for parametro in "$@"; do
   echo "Parametro $contador: $parametro"
   contador=$((contador + 1))
done
