using System.ComponentModel;

internal class Program
{   
    //Cálculo para o comsumo de combustivel por km
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o km inicial:");
        int kminicial = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o km final:");
        int kmfinal = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o combustível utilizado:");
        Double combustivelutilizado = Convert.ToDouble(Console.ReadLine());

        double calculodistancia = kmfinal - kminicial;
        double consumokm = combustivelutilizado / calculodistancia;

        Console.WriteLine("O consumo de combustível/km foi:" + consumokm);
    }
}