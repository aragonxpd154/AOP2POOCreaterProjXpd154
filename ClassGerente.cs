using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_PEDIDOS
{
    public class ClassGerente
    {
        private string senha;

        public string Senha
        {
              get { return senha; }
              set { senha = value; }

        }

        public static void SenhaValidar()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                       ====•CALCULAR DESCONTO MAIOR====");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}



