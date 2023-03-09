namespace ListaExercicios01 //Cálculo do volume de uma caixa retangular. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Cálculo de Volume de uma caixa Retangular");
                Console.WriteLine();
                Console.WriteLine("Digite o valor do comprimento do retângulo: ");
                decimal comprimento = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o valor do altura do retângulo: ");
                decimal altura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o valor do largura do retângulo: ");
                decimal largura = Convert.ToDecimal(Console.ReadLine());

                decimal volume = 0;
                volume = largura * comprimento * altura;

                decimal resultadoFormatado = Math.Round(volume, 2);

                Console.WriteLine("O volume do seu retângulo é: " + resultadoFormatado);
                Console.ReadLine();

                Console.WriteLine("Digite S se deseja fazer outro cálculo de retângulo: ");
                string opcao = Console.ReadLine();

                if (opcao != "s" || opcao != "S")
                {
                    continua = false;
                }
                else if (opcao == "s" || opcao == "S")
                {
                    continue;
                }
            } while (continua);
        }
    }
}