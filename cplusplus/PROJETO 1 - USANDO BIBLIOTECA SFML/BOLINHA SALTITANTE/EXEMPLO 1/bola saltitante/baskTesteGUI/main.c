#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define TAM_SENHA 150  // Tamanho da senha
#define NUM_LETRAS 26  // N�mero de letras do alfabeto

int main(void)
{
    // Inicializa o gerador de n�meros aleat�rios
    srand(time(NULL));

    // Gera uma senha aleat�ria
    char senha[TAM_SENHA + 1];  // +1 para o caractere de termina��o de string
    for (int i = 0; i < TAM_SENHA; i++) {
        // Gera um n�mero aleat�rio entre 0 e 25
        int num = rand() % NUM_LETRAS;

        // Converte o n�mero para uma letra do alfabeto
        char letra = 'a' + num;

        // Adiciona a letra � senha
        senha[i] = letra;
    }

    // Adiciona o caractere de termina��o de string � senha
    senha[TAM_SENHA] = '\0';

    // Exibe a senha gerada
    printf("Senha gerada: %s\n", senha);

    return 0;
}
