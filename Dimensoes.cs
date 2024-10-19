public class Dimensoes
{
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }

    public override string ToString()
    {
        return $"{Altura} cm x {Largura} cm x {Profundidade} cm";
    }
}
