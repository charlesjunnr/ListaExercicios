namespace Exercicio019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Calculadora de IMC - Hora da Verdade");
            Console.WriteLine();
            Console.WriteLine("Digite a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if(imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }else if(imc > 18.5 && imc <= 25)
            {
                Console.WriteLine("Você está com o peso normal!");
            }else if(imc > 25 && imc <= 30)
            {
                Console.WriteLine("Você está acima do peso!");
            }
            else
            {
                Console.WriteLine("Você está obeso!");
            }
            Console.ReadLine();

        }
    }
}