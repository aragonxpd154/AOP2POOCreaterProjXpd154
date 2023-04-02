#include <stdio.h>
int main(){
    float inss, ir, aliquota, calculo, horasTrabalho, valorHoras, salarioLiquido, salarioBruto;

    printf("Insira suas horas trabalhadas: \n");
    scanf("%f", &horasTrabalho);
    printf("Insira o valor de cada hora trabalhada: \n");
    scanf("%f", &valorHoras);
    salarioBruto = horasTrabalho * valorHoras;
    inss = 11/100 * salarioBruto;
    ir = aliquota * (salarioBruto - inss) - calculo;
    salarioLiquido = salarioBruto - inss - ir;
    calculo = aliquota * (salarioBruto - inss);
    
    if(salarioBruto - inss <= 1499.15)
    {
        aliquota = 1;
    }
    if(salarioBruto - inss >= 1499.16 || salarioBruto - inss <= 2246.75)
    {
        aliquota = 0,075;
    }
    if(salarioBruto - inss >= 2246.76 || salarioBruto - inss <= 2995.70)
    {
        aliquota = 0,15;
    }
    if(salarioBruto - inss >= 2995.71 || salarioBruto - inss <= 3743.20)
    {
        aliquota = 0,225;
    }
    if(salarioBruto - inss >= 3743.20)
    {
        aliquota = 0,275;
    }
    
    printf("O salario liquido do empregado = %.2f reais", salarioLiquido);
    
	return 0;
}
