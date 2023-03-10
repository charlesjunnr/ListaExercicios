namespace Exercicio018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC;

            Console.Clear();
            Console.WriteLine("Digite um valor para A: ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");
            valorB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor para C: ");
            valorC = Convert.ToInt32(Console.ReadLine());

            if (valorA > valorB && valorB > valorC)
            {
                Console.WriteLine();
                Console.WriteLine(valorC);
                Console.WriteLine(valorB);
                Console.WriteLine(valorA);
            }
            else if (valorB > valorC && valorC > valorA)
            {
                Console.WriteLine();
                Console.WriteLine(valorA);
                Console.WriteLine(valorC);
                Console.WriteLine(valorB);
            }
            else if (valorC > valorB && valorB > valorA)
            {
                Console.WriteLine();
                Console.WriteLine(valorA);
                Console.WriteLine(valorB);
                Console.WriteLine(valorC);
            }
            else if (valorB > valorA && valorA > valorC)
            {
                Console.WriteLine();
                Console.WriteLine(valorC);
                Console.WriteLine(valorA);
                Console.WriteLine(valorB);
            }
            else if (valorC > valorA && valorA > valorB)
            {
                Console.WriteLine();
                Console.WriteLine(valorB);
                Console.WriteLine(valorA);
                Console.WriteLine(valorC);
            }
            else if (valorA > valorC && valorC > valorB)
            {
                Console.WriteLine();
                Console.WriteLine(valorB);
                Console.WriteLine(valorC);
                Console.WriteLine(valorA);
            }
            Console.ReadLine();
        }
    }
}