#include<stdio.h>
int main()
{

 float temperatura_F,Celsius;

 printf("\n Informe a temperatura na escala Fahrenheit: ");
 scanf("%f",&temperatura_F);

 Celsius=0.555555555*(temperatura_F-32);

 // Exibição do resultado
 printf("\n Temperatura em graus Celsius=%.2f\n",Celsius);

 return 0;
}
