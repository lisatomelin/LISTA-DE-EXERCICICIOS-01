namespace exercicio10. ConsoleApp
{
    internal class Program
    {
        //Calcule a média ponderada de duas notas
        private static void Main(string[] args)
        {
            Console.WriteLine("Cáculo da média ponderada de duas notas");

            Console.WriteLine("Digite o valor da primeira nota:");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota:");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do primeiro peso:");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo peso:");
            double peso2 = Convert.ToDouble(Console.ReadLine());


            double mediaponderada = (nota1 * peso1 + nota2 * peso2) / (peso1 * peso2);

            Console.WriteLine("A média ponderada das duas notas é:" + mediaponderada);

        }
    }
}