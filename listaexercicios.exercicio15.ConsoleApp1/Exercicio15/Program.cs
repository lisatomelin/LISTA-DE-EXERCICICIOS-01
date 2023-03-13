namespace exercicio15
{
    internal class Program
    {
        // Calculo que lê a temperatura em Fahreiheit
        private static void Main(string[] args)
        {
            Console.WriteLine("Temperatura em Fahreiheit!");

            Console.WriteLine("Informe a temperatura em Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A temperatura é:" +  ((celsius * 9/5) + 32) + "Em Fahrenheit");
        }
    }
}