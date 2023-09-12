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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro janelaCadastro = new Cadastro();
            janelaCadastro.MdiParent = this;
            janelaCadastro.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extrato janelaMenu = new Extrato();
            janelaMenu.MdiParent = this;
            janelaMenu.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login janelaLogin = new Login();
            janelaLogin.MdiParent = this;
            janelaLogin.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaqueDeposTrans janelaTransferencia = new SaqueDeposTrans();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }
    }
}
