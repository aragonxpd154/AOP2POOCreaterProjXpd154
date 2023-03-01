# Função soma escrita com Função Lambda

somaDoisNumerosLambda = lambda numero1, numero2: numero1 + numero2
print(somaDoisNumerosLambda(3, 5))

# Filtro de lista apenas elemento impares
listaInicial = [1, 2, 3, 4, 5, 17, 87, 34, 99]

# Retorna a lista de numeros impares
listaFiltrada = list(filter(lambda x: x % 2 != 0, listaInicial))
print (listaFiltrada)

# Função com variavel escopo global

TAXA = 5
def somaComTaxa(a, b):
    TAXA = 3
    return a+b+TAXA

print(somaComTaxa(3, 5))

# Calculo Taxa de cambio

TAXA_DE_CAMBIO = 5.1828
def calculaCambio(valor):
    return valor/TAXA_DE_CAMBIO

print(f'O valor de R$2000,00 em dolares é {calculaCambio(2000)}')

