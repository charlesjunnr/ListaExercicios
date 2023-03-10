namespace Exercicio14 //Conversão de ano para dias.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeAno, idadeD, ano = 365;
            string nomeP;

            Console.WriteLine("Quantos dias você já viveu?");
            Console.WriteLine();
            Console.WriteLine("Digite seu nome por gentileza: ");
            nomeP = Console.ReadLine()!;

            Console.WriteLine("Digite quantos anos você tem: ");
            idadeAno = Convert.ToInt32(Console.ReadLine());
            idadeD = idadeAno * ano;
            Console.WriteLine(nomeP + ", você já viveu " + idadeD + " dias de vida!");
            Console.ReadLine();

        }
    }
}