namespace exercicio11.consoleApp
{
    internal class Program
    {

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false; 
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }

        static void Main()
        {
            Console.Write("Digite um número inteiro positivo: ");
            int num = int.Parse(Console.ReadLine());

            if (IsPrime(num))
            {
                Console.WriteLine(num + " é primo!");
            }
            else
            {
                Console.WriteLine(num + " não é primo.");
            }
        }
    }

    
}