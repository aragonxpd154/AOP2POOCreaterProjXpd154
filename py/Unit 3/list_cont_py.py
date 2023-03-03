# Criando Lista e declando algo conteudo
primeiraLista = ['a']
print(f'O contéudo de primeiraLista é {primeiraLista}')

# Criando Lista vazias

# Declaração de lista Formal
L = list('a')
print(L)

# Criando Lista de tipo inteiro
listaSimples  = [1, 2, 3, 4]
print (f'O valor da lista [e {listaSimples}]')

# Criando lista de varios tipos de dados
listaVariosTipos = ['a', 1, 'python', 15.2]
print(f'O valor da listaVariosTipo é {listaVariosTipos}')

# Criando Lista dentro de lista
listaCompleta = [listaSimples, listaVariosTipos]
print(f'O valor da listaCompleta é  {listaCompleta}')

print(f'O valor da listaSimples na posição nº 1 é {listaSimples[1]}')

# Descobrindo tamanho da lista com a função len()

print(f'O ultimo indice de listaSimple é {len(listaSimples)-1}')

# Funções especificas:
# append: Insere um elemo ao final da lista
# insert: Insere um elemento dada a uma determinada posição da lista. OBRIGATORIO informar o indice one o novo elemento sera inserido
# pop: remove um item de uma dada posição (indice) na lista e retorna o valor.

# Criando lista 
listaDeNumeros = [25, 36, 98, 54, 25, 25]

# Criando lista  2
listaDeNumeros2 = [25, 36, 98, 54, 25, 25]


print(f'A listaDeNumeros inicial tem os elementos {listaDeNumeros}')

# Inserindo elemento na lista
listaDeNumeros.append(65)
print(f'A listaDeNumeors após append tem os elementos {listaDeNumeros}')


# Busca ativo de um elemento na lista 

print(f'O indice do valor 98 é {listaDeNumeros.index(98)}')


# remover itens da lista função pop()

# Removendo elemento da lista
print(f'A listaDeNnumeros original: {listaDeNumeros}')

print("pop():", listaDeNumeros.pop())
print(f'A listaDeNumeros pós pop: {listaDeNumeros}')

print("pop(3):", listaDeNumeros.pop(3))
print(f'A listaDeNumeros pos POP(3): {listaDeNumeros}')

# Usando a função remove()
listaDeNumeros.remove(25)
listaDeNumeros


# Contando a quantidades de vezes que um elemento aparece na lista
listaDeNumeros2.count(25)
