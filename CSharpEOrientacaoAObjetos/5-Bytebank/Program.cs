using _05_Bytebank;
using System;

namespace _5_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela._nome = "Gabriela";
            //gabriela._profissao = "Desenvolvedora C#";
            //gabriela._cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

            //conta._titular = gabriela;
            conta._titular = new Cliente();
            conta._titular._nome = "Gabriela Costa";
            conta._titular._cpf = "434.562.878-20";
            conta._titular._profissao = "Desenvolvedora C#";

            conta._saldo = 500;
            conta._agencia = 563;
            conta._numero = 5634527;

            //conta._titular._nome = "Gabriela Costa";

            //Console.WriteLine(gabriela._nome);
            Console.WriteLine(conta._titular._nome);
        }
    }
}
