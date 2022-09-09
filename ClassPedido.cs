using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
        private int desconto;

        // Usando propriedade e encapsulamento {get} e {set} na public int "Desconto"
        public int Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        // Criando uma lista de pedidos para registro
        public static List<string> listaPedidos = new();

        //public List<ClassPedido> listaDePedidos = new();

        public void BuscarPedido()
        {

        }

        //public static void inserirNaLista(int PedidoId, string DataEmissao, float valorDoProduto, string descricaoDoProduto)
        //{
         //   new ClassPedido { PedidoId = PedidoId, DataEmissao = DataEmissao, ValorDoProduto=valorDoProduto, DescricaoDoProduto=descricaoDoProduto };
        //}

        public void InserirPedido()
        {
            
            // Validando Id
            Console.WriteLine(PedidoId++);
            //listaPedidos.Add(PedidoId.ToString());

            // Registando a data com metodo DateTime.Now
            DataEmissao = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(DataEmissao);
            //listaPedidos.Add(DataEmissao.ToString());

            // Amazenando a entrada valorDoProduto
            Console.WriteLine("Entre com valor do produto: ");            
            valorDoProduto = Convert.ToSingle(Console.ReadLine());
            //listaPedidos.Add(valorDoProduto.ToString());
         

            // Amazendo a entrada valor do produto
            Console.WriteLine("Entre com a descrição do produto: ");
            descricaoDoProduto = Convert.ToString(Console.ReadLine());
            //listaPedidos.Add(descricaoDoProduto.ToString());

            // Condicional se deseja aplicar um desconto Menor ou Maior
            Console.WriteLine("Deseja aplicar um desconto? ");
            Console.WriteLine("1. Desconto Padrão");
            Console.WriteLine("2. Desconto Maior");
            Console.WriteLine("3. Não aplicar desconto");

            // Adicionando elementos na lista em questão
            listaPedidos.Add("");
            listaPedidos.Add(Convert.ToString(PedidoId));
            listaPedidos.Add(DataEmissao);
            listaPedidos.Add(Convert.ToString(valorDoProduto));
            listaPedidos.Add(Convert.ToString(descricaoDoProduto));
            listaPedidos.Add("\n");
            // Armazendo a seleção a variavel desconto
            desconto = Convert.ToInt32(Console.ReadLine());

            // Condicional menu para chamar metodo especifico
            if (desconto == 1)
            {
                Console.WriteLine("TESTE");
                return;
            }
            else if (desconto == 2)
            {
                Console.WriteLine("Desconto Maior");
            }
            else
            {
                Console.WriteLine("Voltando");
                pedidoId++;
                return;
            }

            CalcularPrecoTotal();



        }



        public static void CalcularPrecoTotal()
        {
            Console.WriteLine("Esse é o Preço Total: ijirnfefef");
        }
    }
}
