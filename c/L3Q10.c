    #include <stdio.h>
    #include <math.h>
    #include <stdlib.h>

    int main (void)
    {
      int x, y, soma, prodab, aElevation4, raizQuad, totalprodab, calculo1, calculo2, somaRaiz, seno, modulo, calcSen;

      printf("Digite um numero inteiro: ");
      scanf("%d", &x);

      printf("Digite outro numero inteiro: ");
      scanf("%d", &y);
      soma = x + y;
      prodab = (int)(pow(y, 2) + 0.5);
      totalprodab = x * prodab;
      calculo1 = (int)(pow(x, 2) + 0.5);
      calculo2 = (int)(pow(y, 2) + 0.5);
      aElevation4 = (int)(pow(x, 4) + 0.5);
      somaRaiz = calculo1 + calculo2;
      raizQuad = sqrt(somaRaiz);
      calcSen = (x-y);
      seno = sin(calcSen);
      modulo = ~x + 1;

      printf("A soma dos números (x + y) = %d\n", soma);
      printf("O produto do primeiro número pelo quadrado do segundo (x * y2) = %d\n", totalprodab);
      printf("O primeiro número elevado a quarta (x elevado 4) = %d\n", aElevation4);
      printf("A raiz quadrada da soma dos quadrados ( √(𝑥elevado a 2 + 𝑦elevado a 2)) = %d\n",raizQuad);
      // Não foi espcificado na questão a entrada o mesmo logo considera-se inteira o valor
      printf("O seno da diferença do primeiro número pelo segundo (seno (x – y)); = %d\n", seno);
      printf("O módulo do primeiro número (x) = %d\n", soma);
      return(0);
    }
