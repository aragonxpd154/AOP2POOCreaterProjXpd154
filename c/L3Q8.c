    #include <stdio.h>
    #include <stdlib.h>
    int main (void)
    {
      float a, b, soma, subtracao, mult, divisao;

      printf("Digite um numero tipo flutuante: ");
      scanf("%f", &a);

      printf("Digite outro numero tipo flutuante: ");
      scanf("%f", &b);
      soma = a + b;
      subtracao = a - b;
      mult = a * b;
      divisao = a / b;


      printf("O valor da soma = %.2f\n", soma);
      printf("O valor da subtracao = %.2f\n", subtracao);
      printf("O valor da multiplicacao = %.2f\n", mult);
      printf("O valor da divisao = %.2f\n",divisao);
      return(0);
    }
