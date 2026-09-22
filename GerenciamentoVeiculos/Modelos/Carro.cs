public class Carro : Veiculo
{
    public int QuantidadePortas { get; private set; }

    public Carro(string marca, string modelo, int ano, int quantidadePortas)
        : base(marca, modelo, ano)
    {
        QuantidadePortas = quantidadePortas;
    }

    public override void Acelerar()
    {
        if (VelocidadeAtual + 20 <= 180)
        {
            VelocidadeAtual += 20;
        }
        else
        {
            VelocidadeAtual = 180;
        }
        Console.WriteLine($"O carro acelerou. Velocidade atual: {VelocidadeAtual} km/h");
    }

    public override void Frear()
    {
        if (VelocidadeAtual - 20 >= 0)
        {
            VelocidadeAtual -= 20;
        }
        else
        {
            VelocidadeAtual = 0;
        }
        Console.WriteLine($"O carro freou. Velocidade atual: {VelocidadeAtual} km/h");
    }
}