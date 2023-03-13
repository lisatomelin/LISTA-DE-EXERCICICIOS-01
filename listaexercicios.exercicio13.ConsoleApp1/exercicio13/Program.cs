namespace exercicio13
{
    internal class Program
    {
        //Padaria HOTPAO
        private static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de pães vendidos:");
            int Paes = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas:");
            int broas = int.Parse(Console.ReadLine());
            
            double precoPao = 0.12; 
            double precoBroa = 1.50; 

            double totalPao = Paes * precoPao; 
            double totalBroa = broas * precoBroa; 
            double totalVendas = totalPao + totalBroa;
                        
            Console.WriteLine("Foram vendidos " + Paes + " pães e " + broas + " broas.");
            Console.WriteLine("O total unitário vendo de Pães e Broas foi de:" + (Paes + broas));
            Console.WriteLine("O valor total arrecadado com os pães foi de R$ " + totalPao.ToString("F2"));
            Console.WriteLine("O valor total arrecadado com as broas foi de R$ " + totalBroa.ToString("F2"));
            Console.WriteLine("O valor total arrecadado com as vendas foi de R$ " + totalVendas.ToString("F2"));
            Console.WriteLine("O valor que deve ser depositado é de R$:" + (totalVendas * 10 / 100));


        }
    }
}