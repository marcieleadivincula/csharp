using _05_Bytebank;

namespace _5_Bytebank
{
    public class ContaCorrente
    {
        public Cliente _titular;
        public int _agencia;
        public int _numero;
        public double _saldo;

        //Criando primeira função/método
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;

                //contaDestino._saldo += valor;
                contaDestino.Depositar(valor);

                return true;
            }
        }
    }
}
