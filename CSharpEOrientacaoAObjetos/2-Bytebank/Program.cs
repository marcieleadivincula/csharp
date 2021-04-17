using System;

namespace _2_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta._titular = "Gabriela";

            Console.WriteLine(conta._titular); // default ""
            Console.WriteLine(conta._agencia); // default 0
            Console.WriteLine(conta._numero); // default 0
            Console.WriteLine(conta._saldo); // default 0
        }
    }
}
