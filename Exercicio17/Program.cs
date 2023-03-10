namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorA, valorB, valorC;

            Console.WriteLine("Digite o valor de A: ");
            valorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            valorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            valorC = Convert.ToDouble(Console.ReadLine());

            if( valorA + valorB < valorC )
            {
                Console.WriteLine("O valor de A + B é menor que C!");
            }
            else
            {
                Console.WriteLine("O valor de A + B é maior que C!");
            }
            Console.ReadLine();

        }
    }
}