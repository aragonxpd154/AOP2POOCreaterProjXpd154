#include <stdio.h>
int main(){
    int x, s, a, i;

    printf("Insira o ano atual: \n");
    scanf("%d", &a);
    printf("Ano de nacimento: \n");
    scanf("%d", &x);
    printf("Quantos anos de servico voce tem: \n");
    scanf("%d", &s);

    i = a - x;

    if(i >= 65 || s >= 30 || i >= 60 && s >= 25)
    {
        printf("Voce pode aposentar ");
    }
    else
    {
        printf("Voce nao pode se aposentar ");
    }
    return 0;
}
