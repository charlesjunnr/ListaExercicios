namespace Exercicio6 //Conversor de Celsius para Fahrenheit 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Conversor de Celsius para Fahrenheit");
            Console.WriteLine();
            Console.WriteLine("Digite o valor de ºC para a conversão: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("O valor de " + celsius + "ºC é " + fahrenheit + " ºF.");
            Console.ReadLine();

        }
    }
}