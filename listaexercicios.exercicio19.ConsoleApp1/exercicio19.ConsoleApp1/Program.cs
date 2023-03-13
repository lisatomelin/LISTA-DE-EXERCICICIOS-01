namespace exercicio19.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo do IMC");

            Console.WriteLine("Digite seu peso:");
            double peso = double.Parse (Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("Seu imc é" + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Seu IMC está abaixo do normal");
            }

            else if (imc >= 18.5 && imc < 25)
            {
                Console.Write("Seu IMC esta dentro do intervalo normal");

            }
            else if (imc < 30)
            {

                Console.WriteLine("Seu IMC esta acima do normal");
            }

            else
            {
                Console.WriteLine("Você está acima de 30 e é considerado obeso");
            }
        }
    }
}