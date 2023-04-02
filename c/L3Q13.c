    #include <stdio.h>
    #include <math.h>
    #include <stdlib.h>
    int main (void)
    {
      float nota1, nota2, nota3, media, mediaPond, mediaHarm;

      printf("Digite a nota 1: ");
      scanf("%f", &nota1);

      printf("Digite a nota 2: ");
      scanf("%f", &nota2);

      printf("Digite a nota 3: ");
      scanf("%f", &nota3);

      media = (nota1 + nota2 + nota3)/3;
      mediaPond = (((nota1*3)+(nota2*3)+(nota3*4))/10);
      mediaHarm = (3/((1/nota1)+(1/nota2)+(1/nota3)));

      printf("O valor da media das notas é = %.2f\n", media);
      printf("O valor da media ponderada das notas é = %.2f\n",mediaPond);
      printf("O valor da media harmonicas é = %.2f\n", mediaHarm);

      return(0);
    }
