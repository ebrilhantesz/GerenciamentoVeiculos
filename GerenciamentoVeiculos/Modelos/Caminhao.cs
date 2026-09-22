public class Caminhao : Veiculo
{
    public int CapacidadeCarga {get; private set;}

    public Caminhao(string marca, string modelo, int ano, int capacidadeCarga)
        : base(marca, modelo, ano)
    {
        CapacidadeCarga = capacidadeCarga;
    }

    public override void Acelerar()
    {
        if (VelocidadeAtual + 10 <= 120)
        {
            VelocidadeAtual += 10;
        }
        else
        {
            VelocidadeAtual = 120;
        }
    }

    public override void Frear()
    {
        if (VelocidadeAtual - 10 >= 0)
        {
            VelocidadeAtual -= 10;
        }
        else
        {
            VelocidadeAtual = 0;
        }
    }
}