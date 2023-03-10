namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, nota4, mediaF;
            Console.WriteLine("Calculadora de Média");
            Console.WriteLine();
            Console.WriteLine("Digite a nota do 1º Bimestre: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a nota do 2º Bimestre: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a nota do 3º Bimestre: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a nota do 4º Bimestre: ");
            nota4 = Convert.ToDecimal(Console.ReadLine());

            mediaF = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("Sua média final é " + mediaF);
            //quando utilizamos o 10.0 + 7.5 + 8.5 + 9.0 = 87.5 - não entendi. 
        }
    }
}