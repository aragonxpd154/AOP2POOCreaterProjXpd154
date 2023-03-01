# Para privar um atributo para privado utilize __
class ContaPoupanca():
    # Construtor com os dados basicos de inicialização
    def __init__(self, saldo, numeroDaConta, titular):
        self.__saldo = saldo # Atribuição privado Python esconde esse atributo
        self.__numeroDaConta = numeroDaConta # Atribuição privado Python esconde esse atributo
        self.__titular = titular # Atribuição privado Python esconde esse atributo
    

# Acessando atributo privado metodo comum
#contaPoupancaDeJose = ContaPoupanca(300, '123', 'José')
#print(contaPoupancaDeJose.__saldo)

# Acessando atributo privado maneira correta