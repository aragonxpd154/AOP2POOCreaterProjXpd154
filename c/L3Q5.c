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

    printf("Calculo da expressão a = %d\n", calculoa);
    printf("Calculo da expressão b = %d\n", calculob);
    printf("Calculo da expressão c = %d\n", calculoc);
    printf("Calculo da expressão d = %d\n", calculod);
    printf("Calculo da expressão e = %d\n", calculoe);

    return 0;
}
