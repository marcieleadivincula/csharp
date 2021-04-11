using System;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Área de um trapézio
            double baseMenor = 6.0, baseMaior = 8.0, altura = 5.0;
            double area = (baseMenor + baseMaior) * altura / 2.0;

            Console.WriteLine(area);

            //Área de um trapézio
            float baseMenorF = 6.0f, baseMaiorF = 8.0f, alturaF = 5.0f;
            float areaF = (baseMenorF + baseMaiorF) * alturaF / 2.0f;

            Console.WriteLine(areaF);
        }
    }
}
