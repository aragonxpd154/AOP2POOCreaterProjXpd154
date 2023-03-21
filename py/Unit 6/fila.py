class Fila:
    def __init__(self):
        self.itens = []
    
    # Função para adicionar um novo item a fila
    
    def enqueue(self, item):
        self.itens.append(item)
    
    def dequeue(self):
        return self.intens.pop(0)
    
    def inEmpty(self):
        return self.itens == []
    
    def size(self):
        return len(self.itens)
    
    # Instanciandno um objeto estacionamento que recebe a clasee Fila()
    
    # Verificando se a fila está vazia ou não
    
estacionamento = Fila()
    
if fila.isEmpty:
    print("Não há elementos na fila!!")
else:
    print("Há elementos na fila!!")
        