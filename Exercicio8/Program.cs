namespace Exercicio8 //Calcular o volume de uma Lata de óleo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14, altura, raio, diametro, volume;
            Console.WriteLine("Cálculo do Volume de Uma Lata de Óleo");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do diâmetro da lata: ");
            diametro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura da lata: ");
            altura = Convert.ToDouble(Console.ReadLine());
            raio = diametro / 2;
            volume = pi * (raio * raio) * altura;
            
            Console.WriteLine("O volume da lata é de " + volume + "mL.");
        }
    }
}