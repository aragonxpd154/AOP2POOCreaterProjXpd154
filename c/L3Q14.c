    #include <stdio.h>
    #include <math.h>
    #include <stdlib.h>
    int main (void)
    {
      float baseMaior, baseMenor, altura, calculo1, calculo2, total;

      printf("Digite a base Maior 1: ");
      scanf("%f", &baseMaior);

      printf("Digite a base Menor: ");
      scanf("%f", &baseMenor);

      printf("Digite a altura: ");
      scanf("%f", &altura);

      calculo1 = (baseMaior + baseMenor);
      calculo2 = (pow(calculo1, altura) + 0.5);
      total = calculo2 / 2;

      printf("O valor total é  = %.2f\n", total);

      return(0);
    }
