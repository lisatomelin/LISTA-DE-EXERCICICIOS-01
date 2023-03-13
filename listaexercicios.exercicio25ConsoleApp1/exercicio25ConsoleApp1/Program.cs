namespace exercicio25ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de N");

            Console.Write("Digite um número entre 1 e 10: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do número " + n + ":");

                for (double i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i + " x " + n + " = " + (i * n));
                }
        }        
    }
}