namespace Exercicio4 //Calculadora de Média de Combustível 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmI, kmF, kmT, litros, media;

            Console.WriteLine("Cálculo de Média de Combústivel");
            Console.WriteLine();
            Console.WriteLine("Digite a quilometragem inicial do trajeto: ");
            kmI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final do trajeto: ");
            kmF = Convert.ToDouble(Console.ReadLine());

            kmT = kmF - kmI;

            Console.WriteLine("Digite a quantidade de Litros de Gasolina usadas no trajeto: ");
            litros = Convert.ToDouble(Console.ReadLine());

            media = kmT / litros;

            Console.WriteLine("A média gasta de combústível é " + media + "km/L.");
            Console.ReadLine();


        }
    }
}