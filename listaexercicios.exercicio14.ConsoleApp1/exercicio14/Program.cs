namespace exercicio14
{
    internal class Program
    {
        //Quantos anos uma pessoa viveu
        private static void Main(string[] args)
        {
            Console.WriteLine("Calculo de quantos anos uma pessoa já viveu");

            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite qual a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine(nome + ",você já viveu: " + idade * 365 + "dias");

        }
    }
}