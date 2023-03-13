namespace exercicio21.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de números iguais");

            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                int somaAB = A + B;
                Console.WriteLine("O valor de A + B é:" + somaAB);
            }

            else if (A != B)
            {

                int multiplicaAB = A * B;
                Console.WriteLine("O valor de A * B é:" + multiplicaAB);


            }
        }   
    }
}