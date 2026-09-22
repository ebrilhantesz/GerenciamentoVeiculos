public class GerenciadorVeiculos
{
    private List<Veiculo> listaVeiculos = new List<Veiculo>();

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        listaVeiculos.Add(veiculo);
    }
    
    public void TestarVeiculos()
    {
        foreach (Veiculo veiculo in listaVeiculos)
        {
        veiculo.Acelerar();
        veiculo.Acelerar();
        veiculo.Acelerar();

        Console.WriteLine($"Velocidade atual: {veiculo.VelocidadeAtual} km/h");

        veiculo.Frear();

        Console.WriteLine($"Velocidade final: {veiculo.VelocidadeAtual} km/h");
        }
    }

}