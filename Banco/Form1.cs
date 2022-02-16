using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            conta.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            conta.Titular = cliente;

            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoTitular.Text = Convert.ToString(conta.Titular.Nome);


        }
        private Conta conta;

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            conta.Deposita(valor);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            conta.Saque(valor);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso!");
        }
    }
}
