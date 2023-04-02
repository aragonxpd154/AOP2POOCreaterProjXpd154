#include <stdio.h>
int main(){
    float s, x, y, z;
    printf("insira o salario: \n");
    scanf("%f", &s);
    x = s * 15/100 + s;
    y = s * 10/100 + s;
    z = s * 5/100 + s;

    if(s <= 500)
    {
     printf("Seu novo salario sera de %f", x);
    }
    if(s > 500 && s <= 1000)
    {
     printf("Seu novo salario sera de %f", y);
    }
    if(s > 1000)
    {
     printf("Seu novo salario sera de %f", z);
    }
    return 0;
}
