using System;

namespace _1_Bytebank
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

            contaGabriela._saldo += 200;
            Console.WriteLine("Saldo: " + contaGabriela._saldo);
        }
    }
}
