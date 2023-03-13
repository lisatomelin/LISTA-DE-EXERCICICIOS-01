namespace exercicio28.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa FizzBuzz");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                    Console.WriteLine();
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                    Console.WriteLine();
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(i + " ");
                    Console.WriteLine();
                }
            }
        }
    }
}