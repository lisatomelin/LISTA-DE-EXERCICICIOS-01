namespace exercicio3.ConsoleApp
{
    //calcular o volume de um Cilindro
    //formula do calculo do cilindro V = PI x raio x raio x altura (v=pi*r²*h)

    internal class program
    {
        static void Main(string[] args)
        {


            Console.Write("Digite o valor da altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * raio * raio * altura;
            Console.WriteLine("O valor do volume: " + volume);

            Console.WriteLine();

            Console.Write("Pressione qualquer tecla para fechar . . . ");

        }
    }
}