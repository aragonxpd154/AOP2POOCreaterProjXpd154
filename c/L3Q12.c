    #include <stdio.h>
    #include <stdlib.h>
    int main (void)
    {
      int base, altura, calculo1, calculo2;

      printf("Digite a base: ");
      scanf("%d", &base);

      printf("Digite a altura: ");
      scanf("%d", &altura);
      calculo1 = base * altura;
      calculo2 = calculo1 / 2;


      printf("O valor da soma = %d\n", calculo2);

      return(0);
    }
