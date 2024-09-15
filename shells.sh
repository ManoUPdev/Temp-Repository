#!/bin/bash
# Usa o comando cut para pegar o ultimo campo (shell) e exibe os valores unicos
cut -d: -f7 /etc/passwd | sort | uniq
