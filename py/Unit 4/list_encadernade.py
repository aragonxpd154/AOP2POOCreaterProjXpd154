class Nodo:
    def __init__(self, dado=0, proximoNodo=None):
        self.dado = dado
        self.proximo = proximoNodo
    
    def __repr__(self):
        return f"{self.dado} -> {self.dado}"
    
    def setProximo(self, proximoNodo):
        self.proximo = proximoNodo
    