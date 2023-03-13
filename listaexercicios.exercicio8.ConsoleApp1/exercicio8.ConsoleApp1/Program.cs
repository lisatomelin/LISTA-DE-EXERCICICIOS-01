namespace exercicio8.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, altura;

            Console.WriteLine("Digite o raio:");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = Math.PI * Math.Pow (raio, 2) * altura;
            Console.WriteLine(" O volume é: " + volume);


        }
    }
}