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
## Adicionando a classe base como parâmetro da nova classe (herdando)
class ContaCorrente(ContaPoupanca):
    # Construtor com os dados básico de inicializacao
    def __init__(self, saldo, numeroDaConta, titular):
        # Utilizando o construtor de classe ContaPoupanca
        ContaPoupanca.__init__(self, saldo, numeroDaConta, titular)
    
    def transferir(self, valor, contaDestino):
        # Validamos se o saldo atual é maior que o solicitado
        # Retiramos o valor da ContaCorrente
        if(self,getSaldo() > valor):
            self.sacar(valor)
            # Depositamos o valor na ContaDestino(ContaCorrente ou ContaPoupanca)
            contaDestino.depositar(valor)
            # Retornamos o saldo da ContaCorrente
            return self.getSaldo()
        else:
            return -1