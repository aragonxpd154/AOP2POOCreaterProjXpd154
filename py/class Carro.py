# Definindo o método init recebendo os parâmetros
# Neste exemplo, o construtor __init__() recebe três argumentos: marca, modelo e ano. 
# Ele inicializa as propriedades marca, modelo e ano do objeto Carro com os valores correspondentes.
# Então, quando você cria um novo objeto Carro, você pode passar os valores desejados para o construtor
# meu_carro = Carro("Toyota", "Corolla", 2021)
# Neste caso, meu_carro é um objeto da classe Carro com as propriedades marca definida como "Toyota", modelo definido como "Corolla" e ano definido como 2021.

class Carro:
    def __init__(self, marca, ano_de_fabricacao, cor, quantidades_de_porta):
        #Atribuindo um valor ao atributo marca
        self.marca = marca
        # Atribuindo um valor ao atributo ano_de_fabricação
        self.ano_de_fabricacao = ano_de_fabricacao
        # Atribuindo um valor ao atributo cor
        self.cor = cor
        # Atribuindo um valor ao atributo quantidades_de_porta
        self.quantidades_de_porta = quantidades_de_porta