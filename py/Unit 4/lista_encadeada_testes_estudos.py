# A segue uma classe para representação do nodo

# Nele esta armazenado duas informações importante, valor e referência para o próximo elemento
# O método __repr__ define o comportamento do Nodo quando ele é impresso com a função print()
# E o ultimo método o setProximo, é responsamento por atuializar a referencia para o proximo nodo quando
# um novo for inserido.

class Nodo:
    def __init__(self, dado=0, proximoNodo=None):
        self.dado = dado
        self.proximo = proximoNodo
    
    def __repr__(self):
        return f"{self.dado} -> {self.dado}"
    
    def setProximo(self, proximoNodo):
        self.proximo = proximoNodo
    

# A segui, criando um nodo com instância do objeto

nodo = Nodo(5)
print(f"O valor do dado é {nodo.dado} e a referência para o proximo elemento é {nodo.proximo}")
print(f'A representação do Nodo é; {nodo}')
