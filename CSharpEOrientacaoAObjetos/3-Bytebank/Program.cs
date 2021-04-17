using System;

namespace _3_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela._titular = "Gabriela";
            contaGabriela._agencia = 863;
            contaGabriela._numero = 863452;
            contaGabriela._saldo = 100;

            Console.WriteLine("Titular: " + contaGabriela._titular);
            Console.WriteLine("Agência: " + contaGabriela._agencia);
            Console.WriteLine("Número: " + contaGabriela._numero);
            Console.WriteLine("Saldo: " + contaGabriela._saldo);


            ContaCorrente contaGabrielaCosta = new ContaCorrente();

            contaGabrielaCosta._titular = "Gabriela";
            contaGabrielaCosta._agencia = 863;
            contaGabrielaCosta._numero = 863452;
            contaGabrielaCosta._saldo = 100;

            Console.WriteLine("Titular: " + contaGabrielaCosta._titular);
            Console.WriteLine("Agência: " + contaGabrielaCosta._agencia);
            Console.WriteLine("Número: " + contaGabrielaCosta._numero);
            Console.WriteLine("Saldo: " + contaGabrielaCosta._saldo);

            Console.WriteLine("Igualdade de tipo de referência: " + (contaGabriela == contaGabrielaCosta));

            int idade = 27;
            int idadeDeNovo = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeDeNovo));

            //Duas variáveis que apontam pra mesma referência na memória
            contaGabriela = contaGabrielaCosta;
            Console.WriteLine(contaGabriela == contaGabrielaCosta);

            contaGabriela._saldo = 300;
            Console.WriteLine(contaGabriela._saldo);
            Console.WriteLine(contaGabrielaCosta._saldo);
        }
    }
}
