using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");
            Console.WriteLine("========================================================");

            int idade = 16;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            int age = 68;
            bool ehIdoso = age >= 65;
            Console.WriteLine(ehIdoso);

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
