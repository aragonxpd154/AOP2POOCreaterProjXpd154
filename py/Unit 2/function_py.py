# Importando o pacote datetime para ter acesso as horas

import datetime

# Definindo uma função simples sem retorno em python
def escrevaHora():
    
    # Escrevendo a hora atual
    print(datetime.datetime.now())
    
# Definindo uma função simples com retorno em python
def somaDoisNumeros(a, b):
    return a+b #Retornando um valor com resultado da função

escrevaHora() # Chamando a função escreverHora

resultado = somaDoisNumeros(3, 5) # Atribuindo o retorno da função
print (f'O resultado da função somaDoisNumeros é {resultado}')

# Testando Ordenação

def testaOrdenacao(primeiro, segundo):
    print (f'O primeiro parametro é {primeiro} e o segundo é {segundo}')

testaOrdenacao(primeiro=3, segundo=5)