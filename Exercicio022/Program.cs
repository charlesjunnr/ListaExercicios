namespace Exercicio022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC;
            Console.WriteLine("Qual será o valor de C? ");
            Console.WriteLine("Vejamos, digite um número inteiro para A: ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agora, digite um número inteiro para B: ");
            valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (valorA == valorB)
            {
                valorC = valorA + valorB;
                Console.WriteLine("Uhhh, o valor de C é " + valorC);
            }
            else
            {
                valorC = valorA * valorB;
                Console.WriteLine("Vish, o valor de C é " + valorC);
                Console.ReadLine();
            }
        }
    }
}