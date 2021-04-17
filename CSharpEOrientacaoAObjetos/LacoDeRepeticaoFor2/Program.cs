using System;

namespace LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto - Mão na massa: Aprofundando laços");
            Console.WriteLine("========================================================");

            //Vamos praticar o comando break imprimindo uma matriz triangular, esse é o nosso código:
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Podemos melhorar nosso código, para isso faça as modificações:
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
