namespace exercicio27.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo sequencia de Fibonacci");

            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());
            
            int x = 0, y = 1, z = 0;

            Console.Write(x + " " + y + " ");

            while (z <= n)
            {
                z = x + y;
                if (z <= n)
                {
                    Console.Write(z + " ");
                }
                x = y;
                y = y;
            }
        }
    }
}