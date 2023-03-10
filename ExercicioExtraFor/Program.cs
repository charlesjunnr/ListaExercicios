namespace ExercicioExtraFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 21;
            bool ehPrimo = true;
            for (int i = 2; i < number; i++)
            {
                Console.WriteLine(number % i);
                if(number % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
            if(ehPrimo == true)
            {
                Console.WriteLine("É primo!");

            }
            else
            {
                Console.WriteLine("Não é primo!");
            }
            
        }
    }
}