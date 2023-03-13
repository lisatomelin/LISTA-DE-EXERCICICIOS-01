namespace exercicio7.ConsoleApp
{
    internal class Program
    {
        //Caculo do salário total de um vendedor
        private static void Main(string[] args)
        {
            Console.WriteLine("Calculo do salário");
            Console.WriteLine("Informe o salário:");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas:");
            double totaldevendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o percentual de comissão:");
            double percentual = Convert.ToDouble(Console.ReadLine());

            double salariototal = (percentual / 100) * totaldevendas + salario;
            Console.WriteLine("O salário total é:" + salariototal);


        }
    }
}