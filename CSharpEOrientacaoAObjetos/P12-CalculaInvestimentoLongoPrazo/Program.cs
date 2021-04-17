using System;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calcula Investimento de Longo Prazo");
            Console.WriteLine("========================================================");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 0; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento,  você terá " + valorInvestido);

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
