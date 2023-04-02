#include <stdio.h>
int main(){
    int  x, a, b;
    a = 10;
    b = 20;
    x = 0;
    x = (b > a) ? b : a;
	
    printf("O valor de x = %d", x);

    return 0;
}
