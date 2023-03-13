namespace exercicio22.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("atribuir resultado para variavel C");

            Console.WriteLine("Digite o valor de A:");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor de B:");
            double B = double.Parse(Console.ReadLine());

            double somaC = A + B;
            double subtracaoC = A - B;
            double multiplicacaoC = A * B;
            double divisaoC = A / B;

            Console.WriteLine("Na soma o valor de C é:" + somaC);
            Console.WriteLine("Na subtração o valor de C é:" + subtracaoC);
            Console.WriteLine("Na multiplicação o valor de C é:" + multiplicacaoC);
            Console.WriteLine("Na divisão o valor de C é:" + divisaoC);



        }
    }
}