using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.Design;

namespace SISTEMA_DE_PEDIDOS
{
    class ClassPedido
    {
        // Declarando variavel tipo privada "pedidoId"
        private int pedidoId = 0;

        // Usando propriedades e encapsulamento {get} and {set} na public int PedidoId
        public int PedidoId
        {
            get { return pedidoId; }
            set { pedidoId = value; }
        }

        // Declarando variavel tipo privada "dataEmissao"
        private string dataEmissao;

        // Usando propriedades e encapsulamento {get} and {set} na public DateTime DataEmissao
        public string DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        // Declarando variavel tipo privada "valorDoProduto"
        private float valorDoProduto;

        //Usando propriedades e encapsulamento {get} e {set} na public "ValorDoProduto"
        public float ValorDoProduto
        {
            get { return valorDoProduto; }
            set { valorDoProduto = value; }
        }

        // Declarando variavel tipo privada "descricaoDoProduto"
        private string descricaoDoProduto;

        // Usando propriedade e encapsulamento {get} e {set} na public string "DescriçãoDoProduto"
        public string DescricaoDoProduto
        {
            get { return descricaoDoProduto; }
            set { descricaoDoProduto = value; }
        }

        // Declarando variavel tipo privada para condição desconto
        private int desconto = 1;

        // Usando propriedade e encapsulamento {get} e {set} na public int "Desconto"
        public int Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        // Declarando variavel tipo privada para condição IDconsulta (usaremos para consultar na lista)
        private int IDconsulta;

        // Usando propriedade e encapsulamento {get} e {set} na public int IDConsulta
        public int IDConsulta
        {
            get { return IDconsulta; }
            set { IDconsulta = value; }
        }

        // Criando uma lista de pedidos para registro
        public static List<string> listaPedidos = new();

        public void RegistrarPedido()
        {
            int a = 0; // teste
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Pedido realizado com sucesso");
            Console.WriteLine("------------------------------------------------------------------------------");

            string Pedido = ("Data da Emissão: " + DataEmissao + "\n" + "Valor do Produto: " + Convert.ToString(valorDoProduto) + "\n" + "Descrição: " + Convert.ToString(descricaoDoProduto));

            listaPedidos.Add(Pedido);

            return;
        }

        // Metodo para Buscar Pedido
        public void BuscarPedido()
        {
            Console.Clear();
            Console.WriteLine("♦ Digite o ID do pedido: ");
            IDConsulta = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("CONSULTA A LISTA DE PEDIDOS POR ID");
            Console.WriteLine("------------------------------------------------------------------------------\n");
            IDConsulta--;
            Console.WriteLine(listaPedidos[IDConsulta]);
            Console.WriteLine("\n");

            Console.WriteLine("* - Para voltar ao Menu: ");
            string varPraVoltar = (Console.ReadLine());
            if (varPraVoltar == "*")
            {
                Console.Clear();
                ClassLoja.Menu();
            }
        }

        public void InserirPedido()
        {
            while (desconto == 1) { 
            // Registando a data com metodo DateTime.Now
            DataEmissao = DateTime.Now.ToString("dd-MM-yyyy");

            // Amazenando a entrada valorDoProduto
            Console.WriteLine("♦ Entre com valor do produto: ");            
            valorDoProduto = Convert.ToSingle(Console.ReadLine());

            // Amazendo a entrada valor do produto
            Console.WriteLine("♦ Entre com a descrição do produto: ");
            descricaoDoProduto = Convert.ToString(Console.ReadLine());

            // Condicional se deseja aplicar um desconto Menor ou Maior
            Console.WriteLine("\n♦ Deseja aplicar um desconto? ");
            Console.WriteLine("1 - Desconto Padrão");
            Console.WriteLine("2 - Desconto Maior\n");
     
            Console.WriteLine("4 - Para confirmar o pedido");

            // Armazendo a seleção a variavel desconto
            desconto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // Condicional menu para chamar metodo especifico
            if (desconto == 1)
            {
                Console.WriteLine("Desconto Padrao");
                return;
            }
            else if (desconto == 2)
            {
                Console.WriteLine("Desconto Maior");
            }
            else if (desconto == 4)
            {
                RegistrarPedido();
            }
            else
            {
                return;
            }
            }

        }

        public static void CalcularPrecoTotal()
        {
            Console.WriteLine("Esse é o Preço Total: ijirnfefef");
        }
    }

    internal class Teste
    {
        public object DataEmissao { get; set; }
    }
}
