namespace AOPPOO
{
    class Pedido
    {
        // Declarando variavel tipo privada "descontoSelecao"
        private int descontoSelecao;
        
        // Usando propriedade e encapsulamento {get} e {set} na public int "DescontoSelecao"
        public int DescontoSelecao
        {
            get { return descontoSelecao; }
            set { descontoSelecao = value; }  
        }

        // Declarando variavel tipo privada "pedidoId"
        private int pedidoId = 1;

        // Usando propriedade e encapsulamento {get} e {set} na public int PedidoId
        public int PedidoId
        {
            get { return pedidoId; }
            set { pedidoId = value; }
        }

        // Declarano variavel tipo privada "dataEmissao"
        private string? dataEmissao;

        // Usando propriedade e encapsulamento {get} e {set} na public string "dataEmissao´"
        public string? DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        // Declarando variavel tipo privada "valorDoProduto"
        private float valorDoProduto;

        // Usando propriedade e encapsulamento {get} e {set} na public float "valorDoProduto"
        public float ValorDoProduto
        {
            get { return valorDoProduto; }
            set { valorDoProduto = value; }
        }

        // Declarando variavel tipo privada "descricaoDoProduto"
        private string? descricaoDoProduto;

        // Usando propriedade e encapsulamento {get} e {set} na public string "descricaoDoProduto"
        public string? DescricaoDoProduto
        {
            get { return descricaoDoProduto; }
            set { descricaoDoProduto = value; }
        }

        // Declarando variavel tipo privado "IDconsulta" (usaremos na consulta da lista)
        private int IDconsulta;

        // Usando propriedade e encapsulamento {get} e {set} na public int "IDconsulta"
        public int IDConsulta
        {
            get { return IDconsulta; }
            set { IDconsulta = value; }
        }

        // Declarando variavel tipo privado "IDremove" 
        private int IDremove;

        // Usando propriedade e encapsulamento {get} e {set} na public int "IDremove"
        public int IDRemove
        {
            get { return IDremove; }
            set { IDremove = value; }
        }

        // Declarando variavel tipo privado "i"
        private int i = 0;

        // Usando propriedade e encapsulamento {get} e {set} na public int "i"
        public int I
        {
            get { return i; }
            set { i = value; }
        }

        // Declarando variavel tipo privado "calculoValorTotal"
        private float calculoValorTotal;

        // Usando propriedade e encapsulamento {get} e {set} na public float "CalculoValorTotal"
        public float CalculoValorTotal
        {
            get { return calculoValorTotal; }
            set { calculoValorTotal = value; }
        }


    }
}
