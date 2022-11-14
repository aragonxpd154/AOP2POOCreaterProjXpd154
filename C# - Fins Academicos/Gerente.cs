using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AOPPOO
{
    class Gerente
    {

        // Declarando variavel tipo privada "senha"
        private string senha = "gerente123";

        // Usando propriedades e encapsulamento {get} e {set} na public string "Senha"
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        // * Declarando variavel tipo privada "desconto"
        private int descontoMaior;

        // Usando propriedade e encapsulamento {get} e {set} na public int "desconto"
        public int DescontoMaior
        {
            get { return descontoMaior; }
            set { descontoMaior = value; }
        }

        // Metodo CalcularDescontoMaior()
        public float CalcularDescontoMaior(float valorDoProduto, int DescontoMaior)
        {
            float calculo1 = ((valorDoProduto * DescontoMaior) / 100);
            float calculo2 = (valorDoProduto - calculo1);
            return calculo2;
        }
    }
}
