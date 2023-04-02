#include <stdio.h>

int main()
{
    int y, z, c, x1, x2;
    int soma;

    y = 6;
    z = 8;
    c = 2;

    x1 = ((y* z)-z)/c;
    x2 = (z/2)/y++;

    soma = x1+x2;

    printf("Soma de x1 + x2 = %d\n", soma);

    return 0;
}
