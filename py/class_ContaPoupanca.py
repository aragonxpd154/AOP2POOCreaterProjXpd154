class ContaPoupanca():
    # Construtor com os dados básicos de inicialização
    def __init__(self, saldo, numeroDaConta, titular):
        self.saldo = saldo
        self.numeroDaConta = numeroDaConta
        self.titular = titular

    # Método para realizar a operação de depósito na conta.
    def depositar(self, valor):
        # Aqui apenas somamos o saldo atual com o valor depositado
        self.saldo += valor
        return self.saldo
    # Método pra realizar a operação de saque na conta
    def sacar(self, valor):
        # Aqui precisamos validar se o saldo atual é maior que o valor de saque
        if (self.saldo > valor):
            self.saldo -= valor
            return self.saldo
        else:
            return -1
contaPoupancaDeJose = ContaPoupanca(300, '123', 'José')    

