namespace ListaExercicio01.Exercicio2 //Conversos de Celcius para Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;
            Console.WriteLine("Conversor de Escalas - Fahrenheit para Celsius");
            Console.WriteLine("Digite o valor em ºF para a conversão: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) / 1.8;

            double resultadoFormatado = Math.Round(celsius, 2);

            Console.WriteLine(fahrenheit + "ºF equivalem a " + resultadoFormatado + "ºC.");

            Console.ReadLine();
        }
    }
}