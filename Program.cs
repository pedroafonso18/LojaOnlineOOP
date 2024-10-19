Loja minhaLoja = new Loja();

Dimensoes dimensoesProduto = new Dimensoes { Altura = 2.5, Largura = 35, Profundidade = 25 };
ProdutoFisico produtoFisico = new ProdutoFisico("Notebook", 2999.99m, 2.5, dimensoesProduto, "P001", "Eletrônicos");
minhaLoja.CadastrarProduto(produtoFisico);


ProdutoDigital produtoDigital = new ProdutoDigital("E-book de Programação", 49.99m, 5.5, "PDF", "P002");
minhaLoja.CadastrarProduto(produtoDigital);

Cliente cliente1 = new Cliente("João Silva", "123.456.789-00", "Rua A, 123", "joao@email.com");
minhaLoja.CadastrarCliente(cliente1);

Pedido pedido = minhaLoja.CriarPedido(cliente1);
pedido.AdicionarProduto(produtoFisico);
pedido.AdicionarProduto(produtoDigital);
pedido.RemoverProduto(produtoDigital);
decimal totalPedido = pedido.CalcularTotal();
Console.WriteLine($"Total do pedido: {totalPedido:C}");
minhaLoja.FinalizarPedido(pedido);

minhaLoja.ListarProdutos();
minhaLoja.ListarClientes();
minhaLoja.ListarPedidos();
