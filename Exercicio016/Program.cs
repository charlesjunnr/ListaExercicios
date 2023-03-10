namespace Exercicio016  //aumentar o salário de um funcionário em 15% e imprimir os valores alterados do salário. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioB, salarioF, salarioI, desconto, aumento;
            
            Console.WriteLine("Aumento de salário(IRRAAA)");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do salário inicial: ");
            salarioI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seu salário Inicial era de " + salarioI);
            aumento = 15 * salarioI / 100;
            salarioB = salarioI + aumento;
            Console.WriteLine("Seu salário com aumento sem descontos é de " + salarioB);
            desconto = 8 * salarioB / 100;
            salarioF = salarioB - desconto;
            Console.WriteLine("Seu salário com aumento com descontos é de " + salarioF);
            Console.ReadLine();



        }
    }
}