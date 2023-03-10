namespace Exercicio11 //Identificar se o número é primo ou não.Por motivos de sanidade mental eu pulei esse exercício.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            bool primo = true;
            int numeroDigitado;
            do
            {
                Console.Clear();
                Console.WriteLine("Será que é primo?");
                Console.WriteLine("Digite um número e lhe diremos se é primo ou não: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());


                for (int i = 2; i < numeroDigitado; i++)
                {
                    if (numeroDigitado % i == 0)
                    {
                        primo = false; break;
                    }

                }
                if (primo == true)
                {
                    Console.WriteLine("Seu número é primo!");
                }
                else if (primo == false)
                {
                    Console.WriteLine("Seu número não é primo!");
                }
                Console.WriteLine("Deseja continuar? Digite s caso sim");
                string operacao = Console.ReadLine()!; // o ponto de ! afirma que a string receberá um valor. 

                if (operacao == "S" || operacao == "s")
                {
                    continue;
                }
                else
                {
                    break;
                }
            } while (continuar == true);

        }
    }
}