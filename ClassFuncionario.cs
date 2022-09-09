using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_PEDIDOS
{
    class ClassFuncionario
    {
        // Lista de Funcionarios e suas respectivas matriculas relacionados
        string[] funcionariosNome = new string[] { "MARCOS", "LUIZ", "CAMILLY", "AMANDA"};
        int[] funcionariosMatri = new int[] { 2331, 6001, 1234, 2020, 0000 };


        public static void ValidarFuncionario()
        {
            // ClassFuncionario FuncNome = new();
            // ClassFuncionario FuncMatric = new();

            string[] funcionariosNome = new string[] { "MARCOS", "LUIZ", "CAMILLY" };
            int[] funcionariosMatri = new int[] { 2331, 6001, 1234, 2020 };


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                       ====•VALIDAR FUNCIONARIO====");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("♦ Entre com nome: ");
            string FuncNome = Convert.ToString(Console.ReadLine());
            Console.Write(FuncNome);

            Console.Write("♦ Entre com a matrícula: ");
            int FuncMatric = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            for (int incremento = 0; incremento < 5; incremento++) {
                if (funcionariosNome.Contains(FuncNome) && funcionariosMatri.Contains(FuncMatric))
                {
                    // Debug
                    //Console.WriteLine("O nome esta dentro da lista");
                    ClassLoja.Menu();
                }
                else
                {
                    Console.WriteLine("NOme do funcionario e/ou matricula errada: ");
                    //incremento++;
                    return;
                }
            }
               
        }
    }
}


      
