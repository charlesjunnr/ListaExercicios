namespace Exercicio020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número e direi se ele é par ou ímpar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WriteLine("Seu número é par!");
            }
            else
            {
                Console.WriteLine("Seu número é ímpar!");
            }
        }//numer%2 == 0 - fórmula do cálculo de resto da divisão!
    }
}