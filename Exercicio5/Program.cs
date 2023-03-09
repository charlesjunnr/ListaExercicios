namespace Exercicio5 // Cálculo de Esfera 
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            double volume, raio, diametro, pi = 3.14;
            //const double pi = 3.14
            Console.WriteLine("Cálculo do Volume de um Esfera");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do diâmetro da esfera: ");
            diametro = Convert.ToDouble(Console.ReadLine());
            raio = diametro / 2;
            volume = 1.33 * pi * (raio * raio * raio);
            
            double resultadoFormatado = Math.Round(volume, 2);
            Console.WriteLine("O volume da Esfera é: " + resultadoFormatado + "c³.");
            
        }
    }
}