using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");
            Console.WriteLine("========================================================");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Maior de idade, pode entrar!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Menor de idade, porém está acompanhado. Pode entrar!");
                }
                else
                {
                    Console.WriteLine("Menor de idade. Não pode entrar!");
                }
            }

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
