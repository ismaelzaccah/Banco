﻿using System;
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
            this.c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            c.Titular = cliente;

            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
            textoTitular.Text = Convert.ToString(c.Titular.Nome);


        }
        private Conta c;

        private void button1_Click(object sender, EventArgs e)
        {
            double valorOperacao = Convert.ToDouble(textoValor.Text);
            c.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorOperacao = Convert.ToDouble(textoValor.Text);
            c.Saque(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso!");
        }
    }
}
