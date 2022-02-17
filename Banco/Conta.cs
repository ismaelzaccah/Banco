using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Saque(double valor)
        {
            this.Saldo -= valor;
        }
    }
    public class ContaPoupanca : Conta
    {
        public override void Saque(double valor)
        {
            base.Saque(valor + 0.10);
        }
    }
   
    public class ContaCorrente : Conta
    {
        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }
        public override void Saque(double valor)
        {
            base.Saque(valor + 0.05);
        }
    }
}