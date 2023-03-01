# Verificação de ID de memoria de cada variavel atravez do metodo ID

a = 95
print(f'A variavel a com valor {a} esta no endereço {id(a)}')
a = a + 1
print(f'A variavel a com valor {a} esta no endereço {id(a)}')

lista = ['a', 'b']
print(f'A variavel a com valor {lista} esta no endereço {id(lista)}')

lista.append('c')
print(f'A variavel a com valor {lista} esta no endereço {id(lista)}')

def naoAlteraString(palavra):
    print(f'A palavra inicial (dentro da função) é {palavra}')
    palavra = 'nova'
    print(f'A palavra final (dentro da função) é: {palavra}')

minhaPalavra = 'antiga'
naoAlteraString(minhaPalavra)
print(f'A palavra é: {minhaPalavra}')

def alteraLista(lista):
    print(f'A lista inicial (dentro da função) é:{lista}')
    lista.append('3')
    print(f'A lista final (dentro da função) é:{lista}')

minhaLista = ['a', 'b', 'c']
alteraLista(minhaLista)
print(f'A lista é: {minhaLista}')