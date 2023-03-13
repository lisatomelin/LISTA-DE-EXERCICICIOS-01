using System.ComponentModel.Design;

namespace exercicio17.ConsoleApp
{
    internal class Program
    {
        //Ler os valores de A, B, C e imprimir na tela se a soma de A + B é menor que C
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de A, B e C!");

            Console.WriteLine("Digite o valor de A:");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            double valorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            double valorC = Convert.ToDouble(Console.ReadLine());

            if (valorA + valorB < valorC)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }

            else
            {
                Console.WriteLine("A soma de A + B não é menor que C");
            }
            
        }
    }
}