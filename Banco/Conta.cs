using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        internal void Saque(double valor)
        {
            this.Saldo -= valor;
        }
    }
}