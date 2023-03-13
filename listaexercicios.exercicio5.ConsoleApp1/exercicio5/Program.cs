namespace exercicio5.ConsoleApp
{
    internal class Program
    {
        //Exercicio 5 - Calcular o volume de uma esfera
        private static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio da esfera:");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volumeesfera = 4 * Math.PI * raio * raio * raio / 3;
            Console.WriteLine("O valor do colume da esfera é:" + volumeesfera);

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para sair");



        }
    }









}

    