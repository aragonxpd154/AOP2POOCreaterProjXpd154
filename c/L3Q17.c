#include <stdio.h>
int main(){
    int a, b, c, d, A, B, C, D, E, F, G;
    a = 5;
    b = 4;
    c = 3;
    d = 6;
    A = (a > c) && (c <= d);
    B = (a+b) > 10 || (a + b) == (c + d);
    C = (a>=c) && (d >= c);
    D = (2*c) == d || (a+b) == 9;
    E = a*c/b > a*b*c;
    F = !0;
    G = !3 && 0;
	
    if(A != 0)
    {
        printf("A = Verdadeiro\n");
    }
    else
    {
        printf("A = Falso");
    }

    if(B != 0)
    {
        printf("B = Verdadeiro\n");
    }
    else
    {
        printf("B = Falso\n");
    }
    if(C != 0)
    {
        printf("C = Verdadeiro\n");
    }
    else
    {
        printf("C = Falso\n");
    }
    if(D != 0)
    {
        printf("D = Verdadeiro\n");
    }
    else
    {
        printf("D = Falso\n");
    }
    if(E != 0)
    {
        printf("E = Verdadeiro\n");
    }
    else
    {
        printf("E = Falso\n");
    }
    if(F != 0)
    {
        printf("F = Verdadeiro\n");
    }
    else
    {
        printf("F = Falso\n");
    }
    if(G != 0)
    {
        printf("G = Verdadeiro\n");
    }
    else
    {
        printf("G = Falso\n");
    }
    
}