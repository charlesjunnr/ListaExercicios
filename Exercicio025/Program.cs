namespace Exercicio025 // gerar uma tabuada.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroD;
            Console.WriteLine("Digite um valor para gerar uma tabuada: ");
            numeroD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <=10; i++)
            {
                int resultado = numeroD * i;
                Console.WriteLine(numeroD + " x " + i + " = " + resultado);
            }
            Console.ReadLine();
        }
    }
}