namespace exercicio23.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números Imparesentre 100 e 200");

            for (int i = 100; i <= 200; i++) 
            {
                if (i % 2 !=0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}