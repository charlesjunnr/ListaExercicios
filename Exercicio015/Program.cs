namespace Exercicio015 //Peça em celsius e receba em fahrenheit.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura em graus celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("A temperatura é " + fahrenheit + " ºF.");

        }
    }
}