namespace Exercicio013 //Padaria HotPão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double qtdPao, qtdBroa, valorT, valorP;

            Console.WriteLine("Padaria Hotpão - O seu pão quentinho todo dia.");
            Console.WriteLine();
            Console.WriteLine("Quantos pães foram vendidos hoje? ");
            qtdPao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Quantas broas foram vendidas hoje? ");
            qtdBroa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            valorT = (qtdPao * 0.12) + (qtdBroa * 1.50);

            Console.WriteLine("O valor adquirido hoje foi de " + valorT);
            Console.WriteLine();

            valorP = (10 * valorT) / 100;
            
            Console.WriteLine("O valor poupado do dia é de " + valorP);
            Console.WriteLine();

        }
    }
}