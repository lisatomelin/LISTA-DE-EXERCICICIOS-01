namespace exercicio24.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros impares multiplos de 3 entre 1 ate 500");

            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                { 
                    soma += i; 
                }
            }

            Console.WriteLine("A soma dos números ímpares múltiplos de três entre 1 e 500 é: " + soma);
        }
    }
}