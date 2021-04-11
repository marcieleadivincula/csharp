using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = a / b;

            //Trunca o resultado para inteiro
            Console.WriteLine(resultado); //2

            resultado = (double) a / b;

            //Para que não aconteça precisamos fazer um casting
            Console.WriteLine(resultado); //2.5

            double x;
            int y;

            x = 5.0;
            // y = x; //Assim não dá, precisamos fazer um casting
            y = (int)x;

            Console.WriteLine(y); //
        }
    }
}
