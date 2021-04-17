using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuições de Variáveis");
            Console.WriteLine("========================================================");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 35;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
