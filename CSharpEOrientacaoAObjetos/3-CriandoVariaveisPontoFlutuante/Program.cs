using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variáveis Ponto Flutuante");
            Console.WriteLine("========================================================");
            //double, float

            double salario = 1200.70;
            Console.WriteLine("Salário: " + salario);

            double idade;
            idade = 15;
            Console.WriteLine("Idade: " + idade);

            idade = 15 / 2;
            Console.WriteLine("15 / 2 = " + idade);

            idade = 15.0 / 7;
            Console.WriteLine("15.0 / 7 = " + idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
