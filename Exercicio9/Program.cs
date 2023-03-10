namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, nota4, mediaH;
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

            mediaH = 4 / ((1/nota1) + (1/nota2) + (1/nota3) + (1/nota4));
            
            decimal resultF = Math.Round(mediaH, 2);
            
            Console.WriteLine("Sua média final é " + resultF);
            Console.ReadLine();

            //quando utilizamos o 10.0 + 7.5 + 8.5 + 9.0 = 87.5 - 
            //float - precisão de 6 casas decimais, sendo que a partir de 6 os resultados são menos precisos; double - ocupa mais memória mas pega até 12 casas decimais; 
        }
    }
}