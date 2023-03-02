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