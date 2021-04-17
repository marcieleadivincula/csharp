using System;

namespace _4_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno._titular = "Bruno";

            Console.WriteLine(contaDoBruno._saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno._saldo);
            Console.WriteLine("Resultado do saque: " + resultadoSaque);
            Console.WriteLine(contaDoBruno._saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno._saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela._titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno._saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela._saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno._saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela._saldo);

            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno._saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela._saldo);
        }
    }
}
