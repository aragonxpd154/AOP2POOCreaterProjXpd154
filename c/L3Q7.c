    #include <stdio.h>
    #include <stdlib.h>
    int main (void)
    {
      int a, dobro, triplo;

      printf("Digite um numero inteiro: ");
      scanf("%d", &a);

      dobro = a * a;
      triplo = a * a * a ;

      printf("O valor do dobro da entrada é = %d\n", dobro);
      printf("O valor do triplo da entrada é = %d\n", triplo);
      return(0);
    }
