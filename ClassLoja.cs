using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SISTEMA_DE_PEDIDOS
{
    public class ClassLoja
    {
        // SubClasse de Acesso


        public static int PedidoId { get; private set; }

        
        public static void Menu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Atribuindo metodos da ClassPedido ao objeto InserirPedidoObj
            // Eu sei que da pra simplificar o codigo com isso, mas coloquei para não me perder nas atribuições e classes '-'
            // Depois faz uma limpa no code all right 
            ClassPedido inserirPedido = new();
            ClassPedido buscarPedido = new();
            ClassPedido removerPedido = new();

            // Menu com Descritivos
            Console.WriteLine("                            ====•SISTEMA DE PEDIDOS====");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Inserir Pedido ");
            Console.WriteLine("2. Buscar Pedido ");
            Console.WriteLine("3. Remover Pedido");
            Console.WriteLine("5. Ver todos os pedidos: ");
            Console.WriteLine("");
            Console.WriteLine("6. Sair");
            Console.WriteLine("");

            var menuSelecao = Console.ReadLine();

            if (menuSelecao == "1")
            {
                Console.Clear();
                // Adicionando na variavel somatoria do valor registrado +1
                PedidoId++;
                // Link com objeto ao metodo InserirPedido()
                inserirPedido.InserirPedido();
           
            }

            

            if (menuSelecao == "5")
            {
                foreach (string ele in ClassPedido.listaPedidos) 
                {
                    Console.WriteLine(ele);
                    
                }
                Console.WriteLine("\n");
            }

            if (menuSelecao == "6")
            {
                Console.Clear();
                Environment.Exit(1);
            }
        }

    }
}