namespace exercicio06.ConsoleApp
{
    internal class Program
    {   
        // Converter temperatura de Celsius para Fahrenheit
        private static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Temperatura de Celsius para Fahrenheit");

            Console.WriteLine("Infome a temperatura em Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine("A temperatura em Fahrenheit é:" +  fahrenheit);

        }
    }


}
