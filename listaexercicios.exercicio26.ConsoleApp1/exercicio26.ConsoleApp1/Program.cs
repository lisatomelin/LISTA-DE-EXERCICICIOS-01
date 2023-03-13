namespace exercicio26.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo em fatorial");

            
            Console.Write("Digite um valor inteiro: ");
            int a = int.Parse(Console.ReadLine());

           
            int fatorial = 1;

            while (a > 1)
            {
                fatorial *= a;
                a--;                
                Console.WriteLine( a + "X" + fatorial);
               
            }

            Console.WriteLine("O fatorial de " + a + " é " + fatorial);
        }
    }
}