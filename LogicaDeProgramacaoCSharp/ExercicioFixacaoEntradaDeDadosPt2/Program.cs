using System;
using System.Globalization;

namespace ExercicioFixacaoEntradaDeDadosPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(" ");
            string n = vet[0];
            int age = int.Parse(vet[1]);
            double h = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(n);
            Console.WriteLine(age);
            Console.WriteLine(h.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
