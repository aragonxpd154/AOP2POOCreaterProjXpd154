using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPPOO
{
    class Funcionario
    {
        public void ValidarFuncionario()
        {
            // Instanciando classes
            Loja linkClassLoja = new();

            // Lista de Funcionarios e suas respectivas matriculas relacionados
            string[] funcionariosNome = new string[] { "MARCOS", "LUIZ", "CAMILLY", "AMANDA" };
            int[] funcionariosMatri = new int[] { 2331, 6001, 1234, 2020, 0000 };


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("                       ====•VALIDAR FUNCIONARIO====");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("♦ ENTRE COM SEU NOME: ");
            string? FuncNome = Convert.ToString(Console.ReadLine());
            Console.Write(FuncNome);

            Console.Write("♦ ENTRE COM SUA MATRICULA: ");
            int FuncMatric = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------");

            // Limitando o numeros de pedidos para 1000 com for sobre "incremento"
            for (int incremento = 0; incremento < 1000; incremento++)
            {
                if (funcionariosNome.Contains(FuncNome) && funcionariosMatri.Contains(FuncMatric))
                {
                    linkClassLoja.Menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nNome do funcionario e/ou matricula errada: ");
                    return;
                }
            }
        }
    }
}
