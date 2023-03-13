namespace Exercicio027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
           
            int anterior = 0;
            int atual = 0;
            int proximo = 1;
            string resultado = "0 ";
            
            for (int i = 0; i < 20; i++)
            {
                anterior = atual;
                atual = proximo;
                proximo = atual + anterior;
                resultado += proximo.ToString() + " ";
            }
            System.Console.Write(resultado);
        }
    }
}
/* Console.Clear();
            int numero;
            int anterior = 0;
            int atual = 1;
            int proximo;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write($"\nSequência de Fibonacci até o número {numero}: ");

            while (atual <= numero)
            {
                Console.Write($"{atual} ");

                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
*/