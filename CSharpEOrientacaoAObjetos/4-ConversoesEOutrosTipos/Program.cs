using System;

namespace _4_ConversoesEOutrosTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversões e Outros Tipos");
            Console.WriteLine("========================================================");

            //O double é uma variável ponto flutuante de dupla precisão - 8 bytes
            double salario = 1200.50;
            Console.WriteLine("Salário = " + salario);

            //Type Casting
            int salarioEmInteiro = (int)salario;
            Console.WriteLine("Salário em inteiro: " + salarioEmInteiro);

            //O short é uma variável de 16 bits - 2 bytes
            short numeroPequeno = 150;
            Console.WriteLine("Número pequeno: " + numeroPequeno);

            //O int é uma variável de 32 bits - 4 bytes
            int valorDeInt = 1300000000;
            Console.WriteLine("Tamanho da variável int: " + valorDeInt);

            //O long é uma variável de 64 bits - 8 bytes
            long numeroGrande = 1300000000000000000;
            Console.WriteLine("Número grande: " + numeroGrande);

            //O float é uma variável ponto flutuante de precisão simples - 4 bytes
            float altura = 1.80f;
            Console.WriteLine("Altura = " + altura);

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
