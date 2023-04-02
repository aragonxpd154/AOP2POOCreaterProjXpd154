#include <stdio.h>
int main(){
    int a;
    printf("Insira o ano:\n");
    scanf("%d", &a);
	
    if(a % 400 == 0 || a % 4 == 0 && a % 100 != 0)
    {
        printf("O ano que voce inseriu é ano-bissexto");
    }
    else
    {
        printf("O ano que voce inseriu nao e  ano-bissexto");
    }
    return 0;

}
