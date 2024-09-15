#!/bin/bash
# Esse script junta todos os parâmetros recebidos em uma única palavra.

# Verifica se ao menos um parâmetro foi passado
if [ $# -eq 0 ]; then
  echo "Uso: $0 <palavra1> <palavra2> ... <palavraN>"
  exit 1
fi

# Inicializa uma variável vazia para armazenar o resultado
resultado=""

# Loop através de todos os parâmetros e os concatena
for parametro in "$@"; do
  resultado="$resultado$parametro"
done

# Exibe o resultado final
echo "$resultado"

