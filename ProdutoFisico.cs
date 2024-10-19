public class ProdutoFisico : Produto
{
    public double Peso { get; set; }
    public Dimensoes DimensoesProduto { get; set; }
    public string Categoria { get; set; }

    private const decimal TaxaDeImposto = 0.10m;
    private const decimal CustoPorKg = 5.0m;   
    public ProdutoFisico(string nome, decimal preco, double peso, Dimensoes dimensoes, string codigo, string categoria)
        : base(nome, preco, codigo)
    {
        if (peso <= 0)
        {
            throw new ArgumentException("O peso deve ser maior que zero.");
        }

        Peso = peso;
        DimensoesProduto = dimensoes;
        Categoria = categoria;
    }


    public override decimal CalcularPrecoFinal()
    {
        decimal valorImposto = Preco * TaxaDeImposto;

        decimal custoEnvio = (decimal)Peso * CustoPorKg;

        decimal desconto = 0.0m;
        if (Categoria == "Livros")
        {
            desconto = Preco * 0.10m; 
        }

        decimal precoFinal = Preco + valorImposto + custoEnvio - desconto;

        return precoFinal;
    }

    public override string ToString()
    {
        return $"{Nome} ({Categoria}) - Preço Base: {Preco:C}, Peso: {Peso} kg, Dimensões: {DimensoesProduto}, Preço Final: {CalcularPrecoFinal():C}";
    }
}
