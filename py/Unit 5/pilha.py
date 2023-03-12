### Informaçoes relevantes

# Stack() – Método utilizado para criar uma nova pilha.
# push() – Utilizado para adicionar um item ao topo da pilha.
# pop() – Utilizado para retirar um item da pilha. Será removido sempre o último item que foi adicionado com a operação push.
# peek() – Utilizado para fazer a leitura do item armazenado no topo da pilha, sem removê-lo.
# isEmpty() – Função utilizada para verificar se a pilha está vazia. Se já estiver vazia, não é possível remover mais itens dela.
# size() – Retorna o número de itens presente na pilha. Não necessita parâmetros e retorna um inteiro (valor do tipo int).

pilha = [1,1,2,3,5]
print ("Pilha: ", pilha)

pilha.append(8)
print("Inserindo um elemento: ", pilha)

pilha.append(13)
print("Inserindo outro elemento:", pilha)

pilha.pop()
print("REmovendo um elemento: ", pilha)

pilha.pop()
print("Removendo outro elemento ", pilha)

print ("\n\n\n\n\n\n")

class Node:
    def __init__(self, dado):
        self.dado = dado
        self.anterior = None
        
    def __repr__(self):
        return f'{self.dado} -> {self.anterior}
    '