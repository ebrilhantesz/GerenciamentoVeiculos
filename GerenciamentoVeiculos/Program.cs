public class Program
{
    public static void Main(string[] args)
    {
        Veiculo moto = new Moto("Honda", "CB 500", 2025, 500);
        Veiculo carro = new Carro("Toyota", "Corolla", 2025, 4);
        Veiculo caminhao = new Caminhao("Hyundai", "HR", 2025, 12);

        GerenciadorVeiculos gerenciador = new GerenciadorVeiculos();

        gerenciador.AdicionarVeiculo(moto);
        gerenciador.AdicionarVeiculo(carro);
        gerenciador.AdicionarVeiculo(caminhao);

        gerenciador.TestarVeiculos();
    }

}
