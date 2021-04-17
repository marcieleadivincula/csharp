using System;

namespace AliquotaIR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto  Opcional: Alíquota com ifs");
            Console.WriteLine("========================================================");

            int idade = 16;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Está acompanhado!";
            }
            else
            {
                mensagemAdicional = "Não está acompanhado!";
            }


            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
