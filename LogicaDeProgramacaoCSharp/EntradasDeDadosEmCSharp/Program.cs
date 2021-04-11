using System;

namespace EntradasDeDadosEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string frase = "Bom dia!", x = "Vermelho", y = "Green", z = "Blue", a = "Amarelo", b = "Laranja", c = "Cinza";
            //Console.Write("Digite uma frase: ");
            //string frase = Console.ReadLine();

            //Console.Write("Digite 6 cor: ");
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //string c = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //SPLIT
            //Podemos simplificar ainda mais, removendo a variável s e passando o Console.ReadLine().Split(""); diretamente para o vet.
            Console.WriteLine("Digite três palavras em sequência: ");
            //string s = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(" ");
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
