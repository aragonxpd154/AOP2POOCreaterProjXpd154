using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AOPPOO
{
    class Estagiario
    {

        // * Declarando variavel tipo privada "desconto"
        private int descontoMenor;

        // Usando propriedade e encapsulamento {get} e {set} na public int "desconto"
        public int DescontoMenor
        {
            get { return descontoMenor; }
            set { descontoMenor = value; }
        }


        // Metodo CalcularDescontoMenor()
        public float CalcularDescontoMenor(float valorDoProduto, int DescontoMenor)
        {
            float calculo1 = ((valorDoProduto*DescontoMenor)/100);
            float calculo2 = (valorDoProduto - calculo1);
            return calculo2;
        } 
    }
}
