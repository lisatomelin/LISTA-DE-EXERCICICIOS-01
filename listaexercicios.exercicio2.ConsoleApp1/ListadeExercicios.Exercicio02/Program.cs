namespace Exercicio02
{
    //Converter a temperatura de graus Fahrenheit para graus Celsius

    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Conversão de Temperatura °F para °C");

            Console.WriteLine("Informe a temperatura em Fahrenheit:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());

            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é:" + Celsius);
        }
    }
}

