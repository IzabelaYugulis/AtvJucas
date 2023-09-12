using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjAula1.Classes;

namespace prjAula1
{

    public partial class Extra : Form
    {
        ContaAntiga minhaConta;
        public Extra()
        {
            InitializeComponent();
        }

        public void Extra_Load(object sender, EventArgs e)
        {
            minhaConta = new Conta
               (2, 2, 1000, "Ativa", 1000, DateTime.Now);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnDepositar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valorDeposito.Text, out var res) == false)
            {
                MessageBox.Show("Valor incorreto para depósito!");
            }
            else 
            {
                try
                {
                    lblSaldo.Text = $"Saldo: R$ {minhaConta.Depositar(Convert.ToDouble(valorDeposito.Text)).ToString("n2")}";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
            //minhaConta.Depositar(Convert.ToDouble(valorDeposito.Text));
            //MessageBox.Show(minhaConta.Saldo.ToString(), "Novo Saldo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
               /*minhaConta.Sacar(Convert.ToDouble(valorDeposito.Text));
            MessageBox.Show(minhaConta.Saldo.ToString(), "Novo Saldo");*/
            if (double.TryParse(valorDeposito.Text, out var res) == false)
            {
                MessageBox.Show("Valor incorreto para saque!");
            }
            else
            {
                try
                {
                    lblSaldo.Text = $"Saldo: R$ {minhaConta.Sacar(Convert.ToDouble(valorDeposito.Text)).ToString("n2")}";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValorSaldo_Click(object sender, EventArgs e)
        {
            //lblSaldo.Text = $"Saldo: R$ {minhaConta.Saldo.ToString("n2")}";
            lblSaldo.Text = minhaConta.MostrarSaldo();
        }
    }
}
