using prjAula1.Classes;
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
    public partial class FormCollection : Form
    {
        List<Cliente> Clientes = new List<Cliente>();
        public FormCollection()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {




            try
            {
                Cliente cliente = new Cliente(txtNome.Text, Convert.ToInt32(txtId.Text));
                MessageBox.Show($"Cliente Adicionado com sucesso \n{cliente.Id} : {cliente.nomeCliente} ",
                    "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clientes.Add(cliente);
            }
            catch (FormatException ex)
            {

                MessageBox.Show($"{ex}Formato inválido");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            txtId.Clear();
            txtNome.Clear();
            txtId.Focus();
        }

        private void FormCollection_Load(object sender, EventArgs e)
        {
            //declarando e criando vetores
            /*string[] meuArrayString = new string[3];
            //declarando e criando vetores com valores
            int[] meuArrayInt = { 2, 3, 7, 9, 10 };

            //colocando informação no array
            meuArrayString[0] = "Tobias";
            meuArrayString[1] = "Troldo";
            meuArrayString[2] = "Trita";
            //exibindo informação do array

            string mensagemFinal = "";
            for (int contador = 0; contador < meuArrayString.Length; contador = contador + 1)
            {
                mensagemFinal = mensagemFinal + ($"{meuArrayString[contador]}\n");
            }

            MessageBox.Show(mensagemFinal);*/
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            foreach (var cliente in Clientes)
            {
                lstClientes.Items.Clear();
                //MessageBox.Show($"{cliente.Id}:{cliente.nomeCliente}");
                lstClientes.Items.Add($"{cliente.nomeCliente}-{cliente.Id}");

            }
            for (int i = 0; i  < Clientes.Count; i ++)
            {
                lstClientes.Items.Add($"{Clientes[i].Id}-{Clientes[i].nomeCliente}");     
            }

            //Clientes[2].nomeCliente = "Pepito";
            //MessageBox.Show(Clientes[2].nomeCliente);
        }
    }
}