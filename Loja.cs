using System;
using System.Collections.Generic;

public class Loja
{
    private List<Produto> produtos;
    private List<Cliente> clientes;
    private List<Pedido> pedidos;

    public Loja()
    {
        produtos = new List<Produto>();
        clientes = new List<Cliente>();
        pedidos = new List<Pedido>();
    }


    public void CadastrarProduto(Produto produto)
    {
        if (produto == null)
        {
            Console.WriteLine("Produto inválido.");
            return;
        }

        foreach (var p in produtos)
        {
            if (p.Codigo == produto.Codigo)
            {
                Console.WriteLine("Produto já cadastrado.");
                return;
            }
        }

        produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso.");
    }

    public Produto ConsultarProdutoPorCodigo(string codigo)
    {
        foreach (var produto in produtos)
        {
            if (produto.Codigo == codigo)
            {
                return produto;
            }
        }

        return null;
    }

    public void ListarProdutos()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        Console.WriteLine("Produtos disponíveis na loja:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco:C}");
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente == null)
        {
            Console.WriteLine("Cliente inválido.");
            return;
        }

        foreach (var c in clientes)
        {
            if (c.NumeroIdentificacao == cliente.NumeroIdentificacao)
            {
                Console.WriteLine("Cliente já cadastrado.");
                return;
            }
        }

        clientes.Add(cliente);
        Console.WriteLine($"Cliente {cliente.Nome} cadastrado com sucesso.");
    }

    public Cliente ConsultarClientePorID(string numeroIdentificacao)
    {
        foreach (var cliente in clientes)
        {
            if (cliente.NumeroIdentificacao == numeroIdentificacao)
            {
                return cliente;
            }
        }

        return null;
    }

    public void ListarClientes()
    {
        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
            return;
        }

        Console.WriteLine("Clientes cadastrados na loja:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.NumeroIdentificacao}, Nome: {cliente.Nome}, Contato: {cliente.Contato}");
        }
    }


    public Pedido CriarPedido(Cliente cliente)
    {
        if (cliente == null || !clientes.Contains(cliente))
        {
            Console.WriteLine("Cliente inválido ou não cadastrado.");
            return null;
        }

        Pedido novoPedido = new Pedido(cliente);
        pedidos.Add(novoPedido);
        Console.WriteLine($"Pedido criado para o cliente {cliente.Nome}.");
        return novoPedido;
    }

    public void FinalizarPedido(Pedido pedido)
    {
        if (pedido == null || !pedidos.Contains(pedido))
        {
            Console.WriteLine("Pedido inválido.");
            return;
        }

        pedido.FinalizarPedido();
        Console.WriteLine("Pedido finalizado.");
    }

    public void ListarPedidos()
    {
        if (pedidos.Count == 0)
        {
            Console.WriteLine("Nenhum pedido realizado.");
            return;
        }

        Console.WriteLine("Pedidos realizados:");
        foreach (var pedido in pedidos)
        {
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}, Data: {pedido.DataPedido}, Status: {pedido.Status}, Total: {pedido.CalcularTotal():C}");
        }
    }
}
