#include <stdio.h>

int main()
{
    int x = 20;
    int y = 2;
    int calculoa, calculob, calculoc, calculod, calculoe;

    calculoa = (x-- +x*(x%y));
    calculob = (x--+x*(x%y));
    calculoc = (x--+x*(x%3));
    calculod = (--x+x*(x%3));
    calculoe = (--x+x*(x%x));

    printf("Calculo da express�o a = %d\n", calculoa);
    printf("Calculo da express�o b = %d\n", calculob);
    printf("Calculo da express�o c = %d\n", calculoc);
    printf("Calculo da express�o d = %d\n", calculod);
    printf("Calculo da express�o e = %d\n", calculoe);

    return 0;
}
