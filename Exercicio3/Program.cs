namespace ListaExercicio.Exercicio3 //Cálculo do volume de um CILINDRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, raio, volume, pi = 3.14;

            Console.WriteLine("Cálculo do volume de um Cilindro");
            Console.WriteLine("Digite o valor da altura do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do raio do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());
            raio = raio * raio;

            volume = pi * (altura * raio);
            Console.WriteLine("O volume do cilindro é: " + volume + "c³.");
            Console.ReadLine();

        }
    }
}