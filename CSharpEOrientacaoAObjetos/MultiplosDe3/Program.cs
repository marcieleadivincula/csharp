using System;

namespace MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto - Desafio Opcional: Múltiplos de 3");
            //Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.

            for (int numero = 1; numero < 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine();

            //Outra forma
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
