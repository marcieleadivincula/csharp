using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - For Encadeado");
            Console.WriteLine("========================================================");
            //*
            //**
            //***

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                    //if (coluna == linha)
                    //{
                    //    break;
                    //}

                    if (coluna >= linha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Outro forma
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Com número
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna + 1);
                }
                Console.WriteLine();
            }

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
