public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public Cliente(string nome, string numeroIdentificacao, string endereco, string contato)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome não pode ser vazio.");
        }

        if (string.IsNullOrWhiteSpace(numeroIdentificacao))
        {
            throw new ArgumentException("O número de identificação não pode ser vazio.");
        }

        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações do Cliente:");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Número de Identificação: {NumeroIdentificacao}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Contato: {Contato}");
    }
    
    public override string ToString()
    {
        return $"Nome: {Nome}, Número de Identificação: {NumeroIdentificacao}, Endereço: {Endereco}, Contato: {Contato}";
    }
}
