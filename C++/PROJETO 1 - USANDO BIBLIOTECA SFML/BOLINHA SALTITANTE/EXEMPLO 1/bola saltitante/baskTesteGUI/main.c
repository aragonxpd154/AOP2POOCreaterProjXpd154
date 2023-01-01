#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define TAM_SENHA 150  // Tamanho da senha
#define NUM_LETRAS 26  // Número de letras do alfabeto

int main(void)
{
    // Inicializa o gerador de números aleatórios
    srand(time(NULL));

    // Gera uma senha aleatória
    char senha[TAM_SENHA + 1];  // +1 para o caractere de terminação de string
    for (int i = 0; i < TAM_SENHA; i++) {
        // Gera um número aleatório entre 0 e 25
        int num = rand() % NUM_LETRAS;

        // Converte o número para uma letra do alfabeto
        char letra = 'a' + num;

        // Adiciona a letra à senha
        senha[i] = letra;
    }

    // Adiciona o caractere de terminação de string à senha
    senha[TAM_SENHA] = '\0';

    // Exibe a senha gerada
    printf("Senha gerada: %s\n", senha);

    return 0;
}
