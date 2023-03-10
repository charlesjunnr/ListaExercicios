namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {   double alturaTerreno, baseTerreno, areaTerreno;

            Console.WriteLine("Cálculo de Terreno Retangular");
            Console.WriteLine();
            Console.WriteLine("Digite o valor da base do retângulo: ");
            baseTerreno = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do retângulo: ");
            alturaTerreno = Convert.ToDouble(Console.ReadLine());
            areaTerreno = alturaTerreno * baseTerreno;

            Console.WriteLine("O valor da área é " + areaTerreno);
            Console.WriteLine();


        }
    }
}