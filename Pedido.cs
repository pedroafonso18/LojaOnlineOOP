public class Pedido : ICarriavel
{
    public Cliente Cliente { get; private set; }
    public DateTime DataPedido { get; private set; }
    public StatusPedido Status { get; private set; }
    private List<Produto> produtos;  
    public Pedido(Cliente cliente)
    {
        Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        DataPedido = DateTime.Now;
        Status = StatusPedido.EmProcessamento;
        produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto == null)
        {
            throw new ArgumentException("O produto não pode ser nulo.");
        }

        produtos.Add(produto);
        Console.WriteLine($"{produto.Nome} foi adicionado ao pedido.");
    }
    public void RemoverProduto(Produto produto)
    {
        if (produto != null && produtos.Contains(produto))
        {
            produtos.Remove(produto);
            Console.WriteLine($"{produto.Nome} foi removido do pedido.");
        }
        else
        {
            Console.WriteLine($"{produto?.Nome ?? "Produto"} não encontrado no pedido.");
        }
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;

        foreach (var produto in produtos)
        {
            total += produto.CalcularPrecoFinal();
        }

        return total;
    }

    public void FinalizarPedido()
    {
        if (Status == StatusPedido.EmProcessamento)
        {
            Status = StatusPedido.Concluido;
            Console.WriteLine("Pedido finalizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O pedido não está mais em processamento.");
        }
    }

    public void ExibirPedido()
    {
        Console.WriteLine("Pedido do Cliente: " + Cliente.Nome);
        Console.WriteLine($"Data: {DataPedido}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine("Produtos no pedido:");

        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - Preço Final: {produto.CalcularPrecoFinal():C}");
        }

        Console.WriteLine($"Total do Pedido: {CalcularTotal():C}");
    }
}
