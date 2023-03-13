namespace exercicio18.ConsoleApp1
{
    internal class Program
    {
        //Algoritmo que leia tres valors inteiros e diferentes e mostre-os em ordem decrescente
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo de numeros inteiros");

            Console.Write("Digite o primeiro valor inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor inteiro: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor inteiro: ");
            int c = int.Parse(Console.ReadLine());

            int maior, intermediario, menor;

            if (a > b && a > c)
            {
                maior = a;
                if (b > c)
                {
                    intermediario = b;
                    menor = c;
                }
                else
                {
                    intermediario = c;
                    menor = b;
                }
            }
            else if (b > a && b > c)
            {
                maior = b;
                if (a > c)
                {
                    intermediario = a;
                    menor = c;
                }
                else
                {
                    intermediario = c;
                    menor = a;
                }
            }
            else
            {
                maior = c;
                if (a > b)
                {
                    intermediario = a;
                    menor = b;
                }
                else
                {
                    intermediario = b;
                    menor = a;
                }
            }

            Console.WriteLine("Valores em ordem decrescente: {0}, {1}, {2}", maior, intermediario, menor);
        }
    }
}
    
