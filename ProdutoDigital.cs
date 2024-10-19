public class ProdutoDigital : Produto
{

    public double TamanhoArquivo { get; set; } 
    public string Formato { get; set; }     

    private const decimal TaxaDeDesconto = 0.10m; 

    public ProdutoDigital(string nome, decimal preco, double tamanhoArquivo, string formato, string codigo)
        : base(nome, preco, codigo)
    {
        if (tamanhoArquivo <= 0)
        {
            throw new ArgumentException("O tamanho do arquivo deve ser maior que zero.");
        }

        TamanhoArquivo = tamanhoArquivo;
        Formato = formato;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal valorDesconto = Preco * TaxaDeDesconto;

        decimal precoFinal = Preco - valorDesconto;

        return precoFinal;
    }

    public override string ToString()
    {
        return $"{Nome} ({Formato}) - Preço Base: {Preco:C}, Tamanho: {TamanhoArquivo} MB, Preço Final: {CalcularPrecoFinal():C}";
    }
}
