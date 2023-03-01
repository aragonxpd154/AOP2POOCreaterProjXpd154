# Para privar um atributo para privado utilize __
class ContaPoupanca():
    # Construtor com os dados básicos de inicialização
    def __init__(self, saldo, numeroDaConta, titular):
        self.__saldo = saldo
        self.__numeroDaConta = numeroDaConta
        self.__titular = titular
        
    # Método getter para acessar o atributo saldo
    def getSaldo(self):
        return self.__saldo
    
    # Método setter para modificar o atributo saldo
    def setSaldo(self, novoSaldo):
        self.__saldo = novoSaldo
        
    # Método getter para acessar o atributo numeroDaConta
    def getNumeroDaConta(self):
        # Método getter para o atributo numeroDaConta
        return self.__numeroDaConta
    
    # Método getter para acessar o atributo titular
    def getTitular(self):
        return self.__titular
    
    # Método para realizar a operação de depósito na conta.
    def depositar(self, valor):
        # Aqui apenas somamos o saldo atual com o valor depositado
        self.__saldo += valor
        return self.__saldo
    
    # Método pra realizar a operação de saque na conta
    def sacar(self, valor):
        # Aqui precisamos validar se o saldo atual é maior que o valor de saque
        if (self.__saldo > valor):
            self.__saldo -= valor
            return self.__saldo
        else:
            return -1
    

# Acessando atributo privado metodo comum (Vai da erro de acesso nivel de encapsulamento de atributo privado)
#contaPoupancaDeJose = ContaPoupanca(300, '123', 'José')
#print(contaPoupancaDeJose.__saldo)

# Acessando atributo privado maneira correta
#contaPoupancaDeJose = ContaPoupanca(300, '123', 'José')
#print('O saldo inicial da conta de {} e R$ {:.2f}'.format(contaPoupancaDeJose.getTitular(), contaPoupancaDeJose.getSaldo()))

# Com o método "setSaldo" implementado, podemos agora inserir um novo valor de saldo para a conta, conforme o trecho de code abaixo:
contaPoupancaDeJose.setSaldo(500)
print('O saldo inicia da conta de {} e R${},00'.format(contaPoupancaDeJose.getTitular(), contaPoupancaDeJose.getSaldo()))
