namespace exercicio9.ConsoleApp
{
    internal class program
    {
        //Calculo da média harmonica das notas de um aluno

        static void Main(string[] args)
        
        {

            Console.WriteLine("Digite o numero de notas");
            int numnotas = int.Parse(Console.ReadLine());

            double somainversosnotas = 0;

            for (int i = 1; i <= numnotas; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                somainversosnotas += 1.0 / nota;


            }
            double mediaharmonica = numnotas / somainversosnotas;

            Console.WriteLine($"A média harmônica das notas é: {mediaharmonica:F2}");

        }
    }
}
