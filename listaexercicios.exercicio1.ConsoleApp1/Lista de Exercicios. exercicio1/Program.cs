namespace execicio01.ConsoleApp
{
    //Formula do volume: volume = comprimento x largura x altura

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o comprimento em metros:");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura em metros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a largura em metros:");
            double largura = Convert.ToDouble(Console.ReadLine());

            double volumecaixa = comprimento * largura * altura;

            Console.WriteLine("O volume em m³ é:" + volumecaixa);

        }


    }







}

