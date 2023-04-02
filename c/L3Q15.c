#include <stdio.h>
int main(){
    float precoL, tanque, kmInicial, kmFinal, litroGasto, km, kmL, autonomia, c;
    
    printf("Insira a quilometragem no inicio da viagem:\n");
    scanf("%f", &kmInicial);
    printf("Insira a quilometragem no fim da viagem:\n");
    scanf("%f", &kmFinal);
    printf("Insira o preco do litro de combustivel:\n");
    scanf("%f", &precoL);
    printf("Insira a capacidade do tanque:\n");
    scanf("%f", &tanque);
    printf("Insira quantos litros foram gastos na viagem:\n");
    scanf("%f", &litroGasto);
    km = kmFinal - kmInicial;
    kmL = km / litroGasto;
    autonomia = tanque * kmL;
    c = litroGasto * precoL;

    printf("O motorista andou  %f KM", km);
    printf("O veiculo faz %f quilometros por litro", kmL);
    printf("A autonomia do veiculo = %f quilometros por tanque", autonomia);
    printf("O custo da viagem foi de %f reais", c);
    return 0;
}
