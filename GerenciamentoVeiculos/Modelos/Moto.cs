public class Moto : Veiculo
{
    public int Cilindradas {get; private set;}

    public Moto(string marca, string modelo, int ano, int cilindradas)
        : base(marca, modelo, ano)
    {
        Cilindradas = cilindradas;
    }
        
    public override void Acelerar()
    {
        if (VelocidadeAtual + 30 <= 220)
        {
            VelocidadeAtual += 30;
        }
        else
        {
            VelocidadeAtual = 220;
        }
    }

    public override void Frear()
    {
        if (VelocidadeAtual - 30 >= 0)
        {
            VelocidadeAtual -= 30;
        }
        else
        {
            VelocidadeAtual = 0;
        }
    }
}