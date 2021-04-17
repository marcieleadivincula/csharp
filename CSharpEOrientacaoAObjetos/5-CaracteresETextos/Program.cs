using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres E Textos");
            Console.WriteLine("========================================================");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine("Caracter = " + primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine("65 = " + primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("Primeiraletra + 1 = " + primeiraLetra);

            string texto = "Olá mundo!";
            Console.WriteLine("Texto = " + texto);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            string cursosProgramacao = @"- .NET 
-  Java
- JavaScript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 45;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.WriteLine("========================================================");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
        }
    }
}
