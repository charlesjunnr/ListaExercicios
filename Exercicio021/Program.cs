namespace Exercicio021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorT;

            Console.WriteLine("Vejamos, digite um número inteiro para A: ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agora, digite um número inteiro para B: ");
            valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if(valorA == valorB)
            {
                valorT = valorA + valorB;
            }
            else
            {
                valorT = valorA * valorB;
                Console.ReadLine();
            }
        }
    }
}