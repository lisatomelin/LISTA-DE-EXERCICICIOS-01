namespace exercicio12 
{
    internal class Program
    {
        //Ler e calcular as dimessoes de um terreno
        private static void Main(string[] args)
        {
            Console.WriteLine("Dimensões de um terreno");

            Console.WriteLine("Digite a largura do terreno:");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a comprimento do terreno:");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            double areadoterreno = largura * comprimento;
            Console.WriteLine("A Area do terreno em m² é:" + areadoterreno);


        }
    }
}