#!/bin/bash
# Le o arquivo /etc/passwd linha por linha
while IFS=: read -r usuario senha uid gid nome completo shell; do
   # Exibe o nome do usuario e o nome completo, separados por TAB
   echo -e "$usuario\t$nome"
done < /etc/passwd
