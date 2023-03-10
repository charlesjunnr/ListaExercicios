namespace Exercicio024 // efetuar a soma de todos os múltiplos de 3 ímpares entre 1 e 500.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iSoma = 0;
            for(int i = 3; i < 500; i += 3)
            {
                Console.WriteLine(i);
                if(i%2 != 0)
                {
                 iSoma = iSoma + i;
                }
            }
            Console.WriteLine("A soma dos múltiplos de 3 é de " + iSoma);
        } //Perguntar por que deu esse valor.
    }
}