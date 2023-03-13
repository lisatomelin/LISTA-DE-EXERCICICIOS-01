namespace exercicio29.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de 1 até 10");

            for (int i =1; i <= 10; i++)
            {
                for (int num = 1; num<=10; num ++)
                {
                    Console.WriteLine($"{i} x {num} = {i * num} \t");
                }
                Console.WriteLine();
            }

        }
    }
}