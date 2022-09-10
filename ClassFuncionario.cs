using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SISTEMA_DE_PEDIDOS
{
    class ClassFuncionario
    {
        // Lista de Funcionarios e suas respectivas matriculas relacionados
        string[] funcionariosNome = new string[] { "MARCOS", "LUIZ", "CAMILLY", "AMANDA"};
        int[] funcionariosMatri = new int[] { 2331, 6001, 1234, 2020, 0000 };

        public static void ValidarFuncionario()
        {
            try { 
            string[] funcionariosNome = new string[] { "MARCOS", "LUIZ", "CAMILLY", "AMANDA" };
            int[] funcionariosMatri = new int[] { 2331, 6001, 1234, 2020, 0000 };


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                       ====•VALIDAR FUNCIONARIO====");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("♦ Entre com nome: ");
            string FuncNome = Convert.ToString(Console.ReadLine());
            Console.Write(FuncNome);

            Console.Write("♦ Entre com a matrícula: ");
            int FuncMatric = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------");
            for (int incremento = 0; incremento < 5; incremento++) {
                if (funcionariosNome.Contains(FuncNome) && funcionariosMatri.Contains(FuncMatric))
                {
                    
                    ClassLoja.Menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nNome do funcionario e/ou matricula errada: ");
                    ValidarFuncionario();
                }
            }

            }
            catch(Exception)
            {
                Console.WriteLine("Digite um valor valido");
                return;
            }
        }
    }
}


      
