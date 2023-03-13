namespace Exercicio029 //tabuada 1 até o 10 (Junior Souza)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tabuada do 1 até o 10");
            Console.WriteLine();
            int num2 = 10;
            for (int i = 1; i <= num2; i++)
            {
                for (int a = 1; a <= num2; a++) { 

                    int resultado = i * a;
                    Console.WriteLine(i + " x " + a + " = " + resultado);
                }
            }
            Console.ReadLine();
        }
    }
}