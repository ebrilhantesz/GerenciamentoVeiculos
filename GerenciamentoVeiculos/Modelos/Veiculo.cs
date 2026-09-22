public abstract class Veiculo
{
    public string Marca {get; private set;}
    public string Modelo {get; private set;}
    public int Ano {get; private set;}
    public int VelocidadeAtual {get; protected set;}

    protected Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public abstract void Acelerar();
    public abstract void Frear();
}