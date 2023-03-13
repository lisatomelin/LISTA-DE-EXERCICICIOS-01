namespace exercicio16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Calculo do salario com aumentos e desconto!");

            Console.WriteLine("Digite seu salário valor bruto:");
            double salario = Convert.ToDouble(Console.ReadLine());

            double salariocomaumento = salario + (salario * 15 / 100);
            Console.WriteLine("Seu salário com aumento de 15% é:" + salariocomaumento);

            double salariocomdesconto = salariocomaumento - (salariocomaumento * 8 / 100);
            Console.WriteLine("Seu salário liquido com desconto de 8% de impostos é: R$ " + salariocomdesconto);
        }
    }
}