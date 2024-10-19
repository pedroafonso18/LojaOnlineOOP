public abstract class Produto
{
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public decimal Preco { get; protected set; }
    
    public Produto(string nome, decimal preco, string codigo)
    {
        Nome = nome;
        Preco = preco;
        Codigo = codigo;
    }

    public abstract decimal CalcularPrecoFinal();
}
