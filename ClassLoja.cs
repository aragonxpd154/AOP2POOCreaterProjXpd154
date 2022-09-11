
namespace SISTEMA_DE_PEDIDOS
{
    public class ClassLoja
    {
        // SubClasse de Acesso
        public static int PedidoId { get; private set; }

        public static void OrdenandoLista()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("LISTA ORDENADA DE ITENS DE PEDIDO");
            Console.WriteLine("------------------------------------------------------------------------------");
            int orgarnizarID = 1;
            foreach (string pedido in ClassPedido.listaPedidos)
            {
                Console.WriteLine("Pedido nº: " + orgarnizarID + "\n" + pedido + "\n");
                orgarnizarID++;

            }
            Console.WriteLine("\n");
            return;
        }
        
        public static void Menu()
        {
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Atribuindo metodos da ClassPedido ao objeto linkClassPedido

            ClassPedido LinkClassPedido = new();

            // Menu com Descritivos
            Console.WriteLine("                            ====•SISTEMA DE PEDIDOS====");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("1 - Inserir Pedido ");
            Console.WriteLine("2 - Buscar Pedido ");
            Console.WriteLine("3 - Remover Pedido");
            Console.WriteLine("4 - Ver todos os pedidos: ");
            Console.WriteLine("");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("\n");

            int menuSelecao = Convert.ToInt32(Console.ReadLine());

            if (menuSelecao == 1)
            {
                Console.Clear();
                // Link com objeto ao metodo InserirPedido()
                LinkClassPedido.InserirPedido();
           
            } 

            if (menuSelecao == 2)
            {
                LinkClassPedido.BuscarPedido();
            }
            if (menuSelecao == 4)
            {
                OrdenandoLista();
            }

            if (menuSelecao == 5)
            {
                Console.Clear();
                Environment.Exit(1);
            }
            else
            {
                return;
            }
        }

    }
}