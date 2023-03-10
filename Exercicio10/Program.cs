namespace Exercicio10 //Cálculo de Média Ponderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal peso1, nota1, peso2, nota2, notaF;

            Console.WriteLine("Cálculo de Média Ponderada");
            Console.WriteLine();
            Console.WriteLine("Digite o valor da primeira nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso da primeira nota: ");
            peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso da segunda nota: ");
            peso2 = Convert.ToDecimal(Console.ReadLine());

            notaF = (peso1 * nota1 + peso2 * nota2) / (peso1 + peso2);
            
            decimal resultadoFormatado = Math.Round(notaF, 2);
            
            Console.WriteLine("Sua média das duas provas é: " + resultadoFormatado);
            Console.ReadLine();
        }
    }
}