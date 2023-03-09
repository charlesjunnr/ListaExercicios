namespace Exercicio7    //Cálculo de Comissão Vendas 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, vendas, comissao, salarioT, comissaoF;
            
            Console.WriteLine("Cálculo de Salário");
            Console.WriteLine();
            Console.WriteLine("Digite o salário base em reais: ");
            salarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor em reais das vendas: ");
            vendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número da porcentagem da comissão: ");
            comissao = Convert.ToDouble(Console.ReadLine());

            comissaoF = comissao / 100 * vendas;
            salarioT = salarioBase + comissaoF;

            Console.WriteLine("O seu salário total é de: R$ " + salarioT);
            Console.ReadLine();

        }
    }
}