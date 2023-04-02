    #include <stdio.h>
    #include <math.h>
    #include <stdlib.h>
    int main (void)
    {
      int x, raioCalc, calculo1;

      printf("Digite o raio: ");
      scanf("%d", &x);

      calculo1 = (int)(pow(x, 2) + 0.5);
      raioCalc = calculo1 *  M_PI;

      printf("O valor da Área do Circulo é de = %d\n", raioCalc);

      return(0);
    }
