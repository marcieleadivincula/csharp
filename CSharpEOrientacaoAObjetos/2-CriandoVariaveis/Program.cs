using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int idade = 32;
            Console.WriteLine("A idade é: " + idade);

            idade = 10 + 5;
            Console.WriteLine("Idade = " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("Idade = " + idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Idade = " + idade);

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
