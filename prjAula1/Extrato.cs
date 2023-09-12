using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class Extrato : Form
    {
        public class Cliente : Cadastro
        {


            public Cliente()
            {

            }
        }
        public Extrato()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var telamenu = new Login();
            this.Hide();
            telamenu.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tranferencia = new SaqueDeposTrans();
            this.Hide();
            tranferencia.Show();
        }



        public void lblLogin_Click(object sender, EventArgs e)
        {

        }


    }

}
