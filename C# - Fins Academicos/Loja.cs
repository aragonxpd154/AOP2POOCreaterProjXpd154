
namespace AOPPOO
{
    class Loja
    {
        // Instanciando classes
        Pedido linkClassPedido = new();
        Estagiario linkClassEstagiario = new();
        Gerente linkClassGerente = new();
        
        // Criando uma lista de pedidos para registro
        public static List<Pedido> listaPedido = new();

        // Metodo Menu()
        public void Menu()
        {
            // Deixando o console com a cor Green
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|                               SISTEMA DE PEDIDOS                              |");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(" 1 - INSERIR PEDIDO: ");
            Console.WriteLine(" 2 - BUSCAR PEDIDO:  ");
            Console.WriteLine(" 3 - REMOVER PEDIDO: ");
            Console.WriteLine(" 4 - CALCULAR VALOR TOTAL DOS PEDIDOS");
            Console.WriteLine("\n 5 - SAIR: \n");

            // Declarando variavel para opção do menu
            string? menuSelecao = Convert.ToString(Console.ReadLine());

            if (menuSelecao == "1")
            {
                // Limpando Console
                Console.Clear();

                // Acessando metodo InserirPedido
                InserirPedido();

            }
            else if (menuSelecao == "2")
            {
                // Limpando Console
                Console.Clear();

                // Acessando metodo BuscarPedido()
                BuscaPedido();
            }
            else if (menuSelecao == "3")
            {
                // Limpando Console
                Console.Clear();

                // Acessando metodo RemoverPedido()
                RemoverPedido();
            }
            else if(menuSelecao == "4")
            {
                CalcularPrecoTotal();
            }
            else if (menuSelecao == "5") 
            {
                // Limpando console
                Console.Clear();
                Environment.Exit(1);
            }
            else
            {
                return;
            }

        }

        // Metodo InserirPedido()
        public void InserirPedido()
        {
            // Deixando o console com a cor Blue
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|                                INSERIR PEDIDO                                 |");
            Console.WriteLine("---------------------------------------------------------------------------------");

            // Inserindo na classe Pedido e na variavel DataEmissao a Data de hoje
            linkClassPedido.DataEmissao = DateTime.Now.ToString("dd-MM-yyyy");

            // Console
            Console.WriteLine(" ENTRE COM O VALOR DO PRODUTO: ");
            // Armazenando o pedido e colocando na variavel ValorDoProduto
            linkClassPedido.ValorDoProduto = Convert.ToSingle(Console.ReadLine());

            // Console
            Console.WriteLine(" ENTRE COM A DESCRIÇÃO DO PRODUTO: ");
            // Armazenando o pedido e colocando na variavel Descricao
            linkClassPedido.DescricaoDoProduto = Convert.ToString(Console.ReadLine());

            // Console

            Console.WriteLine("\n 1 - DESCONTO PADRÃO: ");
            Console.WriteLine(" 2 - DESCONTO MAIOR:  ");
            Console.WriteLine("\n 3 - CONFIRMAR: \n");

            // Armazendo valor da seleção em uma variavel desconto
            linkClassPedido.DescontoSelecao = Convert.ToInt32(Console.ReadLine());

            if (linkClassPedido.DescontoSelecao == 1)
            {
                // Console
                Console.WriteLine(" DIGITE O VALOR DE DESCONTO (%): ");
                linkClassEstagiario.DescontoMenor = Convert.ToInt32(Console.ReadLine());
                if (linkClassEstagiario.DescontoMenor <= 30)
                {
                    // Passando parâmetro para o metodo CalcularDescontoMenor do Funcionario Tipo Estagiario
                    linkClassEstagiario.CalcularDescontoMenor(linkClassPedido.ValorDoProduto, linkClassEstagiario.DescontoMenor);

                    // Console
                    Console.WriteLine(linkClassEstagiario.CalcularDescontoMenor(linkClassPedido.ValorDoProduto, linkClassEstagiario.DescontoMenor));
                    // Registrando em variavel
                    //float valor = (linkClassEstagiario.CalcularDescontoMenor(linkClassPedido.ValorDoProduto, linkClassEstagiario.DescontoMenor));
                    linkClassPedido.ValorDoProduto = (linkClassEstagiario.CalcularDescontoMenor(linkClassPedido.ValorDoProduto, linkClassEstagiario.DescontoMenor));
                    CadastrarNaLista();
                }
                else if (linkClassEstagiario.DescontoMenor > 30)
                {
                    Console.WriteLine(" DESCONTO ALEM DO PERMITIDO");
                    return;
                }
            }
            else if (linkClassPedido.DescontoSelecao == 2)
            {
                {
                    // Console
                    Console.WriteLine(" DIGITE O VALOR DE DESCONTO (%): ");
                    linkClassGerente.DescontoMaior = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("|                                 VALIDAR GERENTE                               |");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine(" DIGITE A SENHA GERENTE: ");

                    // Armazenando a senha na variavel tipo local string "SenhaDigitada"
                    string? SenhaDigitada = (Convert.ToString(Console.ReadLine()));
                    if (SenhaDigitada == linkClassGerente.Senha)
                    {
                        if (linkClassGerente.DescontoMaior <= 30)
                        {
                            linkClassGerente.CalcularDescontoMaior(linkClassPedido.ValorDoProduto, linkClassGerente.DescontoMaior);
                            Console.WriteLine(linkClassGerente.CalcularDescontoMaior(linkClassPedido.ValorDoProduto, linkClassGerente.DescontoMaior));
                            linkClassPedido.ValorDoProduto = (linkClassGerente.CalcularDescontoMaior(linkClassPedido.ValorDoProduto, linkClassGerente.DescontoMaior));
                            CadastrarNaLista();
                        }
                    }
                }

            }
            else if (linkClassPedido.DescontoSelecao == 3)
            {
                CadastrarNaLista();
            }
            else
            {
                return;
            }

        }

        // Metodo BuscarPedido();
        public void BuscaPedido()
        {
            // Limpando console
            Console.Clear();
            
            // Console
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|                                BUSCAR PEDIDO                                  |");
            Console.WriteLine("---------------------------------------------------------------------------------\n");

          
                foreach (Pedido pedido in listaPedido)
                {
                    // Console
                    Console.WriteLine("Pedido nº: " + pedido.PedidoId + "\nData da Emissão: " + pedido.DataEmissao + "\nDescrição do Produto: " + pedido.DescricaoDoProduto + "\nValor do Produto: R$" + pedido.ValorDoProduto + "\n");
                    // Console
                }
           

            // Retorno ao Metodo Menu();
            Menu();

        }

        // Metodo RemoverPedido();
        public void RemoverPedido()
        {
            // Limpando o console
            Console.Clear();

            // Console
            Console.WriteLine("DIGITE O ID DO PEDIDO PARA REMOVER-LO");

            // Armazendo na variavel IDRemove a entrada do usuario
            linkClassPedido.IDRemove = (Convert.ToInt32(Console.ReadLine()));

            // Console
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|                                REMOVER PEDIDO                                 |");
            Console.WriteLine("---------------------------------------------------------------------------------\n");

            // Debug para Listar os Objetos dentro da Lista
            //Console.WriteLine(String.Join(", ", listaPedido));

            // Condição para remover itens da ListaPedido via foreach
            Pedido toRemove = null;
            foreach (Pedido i in listaPedido)
            {
                if (i.PedidoId == linkClassPedido.IDRemove)
                {
                    toRemove = i;
                    break;
                }
            }
            if (toRemove != null)
            {
                listaPedido.Remove(toRemove);
            }

            // Retorno ao Metodo Menu();
            Menu();

        }     

        // Metodo CadastrarNaLista()
        public void CadastrarNaLista()
        {
            // Limpando Console
            Console.Clear();

            //Console
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|                      PEDIDO REGISTRADO COM SUCESSO                            |");
            Console.WriteLine("---------------------------------------------------------------------------------");

            // Criando um objeto da instancia Pedido
            Pedido pedido = new()
            {
                // Adicionando as entradas no objeto em questão
                PedidoId = linkClassPedido.PedidoId++,
                DataEmissao = linkClassPedido.DataEmissao,
                DescricaoDoProduto = linkClassPedido.DescricaoDoProduto,
                ValorDoProduto = linkClassPedido.ValorDoProduto
            };

            // Adicionando o objeto criado na listaPedido
            listaPedido.Add(pedido);

            linkClassPedido.CalculoValorTotal += linkClassPedido.ValorDoProduto;
            
            // Retornando ao Metodo Menu();
            Menu();
        }
        // Metodo CalcularPrecoTotal()
        public void CalcularPrecoTotal()
        {
            // Repassando valores a string e os valores somados
            Console.WriteLine($"\nCALCULO DO PRECO TOTAL É DE R$ {linkClassPedido.CalculoValorTotal}");
            Menu();
        }
        
    }
}
