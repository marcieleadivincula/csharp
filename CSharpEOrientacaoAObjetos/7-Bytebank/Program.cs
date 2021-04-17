using System;

namespace _7_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 8472202);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente gab = new ContaCorrente(867, 848485175);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
