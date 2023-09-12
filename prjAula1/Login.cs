using System.Configuration;
using System.Data;
using System.Numerics;
using Microsoft.Data.SqlClient;
using prjAula1.Classes;

namespace prjAula1
{
    public partial class Login : Form
    {
        private object UsuarioLogado;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new Cadastro();
            this.Hide();
            menu.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Criando uma conexão
            SqlConnection conexao =
            new SqlConnection(ConfigurationManager.ConnectionStrings["UI.Properties.Settings.strConexao"].ToString());
            SqlDataReader leitor; //declarando uma variável do tipo leitor de dados
            //Criando um comando
            SqlCommand cmd = new SqlCommand();
            //criando texto do comando, tipo e conexão que será usada
            cmd.CommandText = "ps_validaLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;
            //ler novamente o leitor
            leitor = cmd.ExecuteReader();



            //verificar se há linhas retornadas do leitor
            if (leitor.HasRows)
            {
                //repete a leitura e enquanto há linhas segue na estrutura
                //de repetição
                while (leitor.Read())
                {
                    //cria uma conta na memória
                    ContaAntiga conta = new Conta();
                    //passa os dados do leitor para a conta na memória - objeto conta
                    conta.IdConta = leitor.GetInt32(0);
                    conta.IdCliente = leitor.GetInt32(1);
                    conta.DataAbertura = leitor.GetDateTime(2);
                    conta.Saldo = leitor.GetDecimal(4);
                    conta.Status = leitor.GetString(5);
                    conta.Senha = leitor.GetString(6);



                    //adiciona a conta recém criada na memória para a colection de contas
                    UsuarioLogado.Conta.Add(conta);
                }
            }

            UsuarioLogado.Id = leitor.GetInt32(0);
            UsuarioLogado.NomeCorrentista = leitor.GetString(1);
            UsuarioLogado.DataNascimento = leitor.GetDateTime(2);
            UsuarioLogado.Logradouro = leitor.GetString(3);
            UsuarioLogado.Numero = leitor.GetString(4);
            if (!leitor.IsDBNull(5))
            {
                UsuarioLogado.Complemento = leitor.GetString(5);
            }

            UsuarioLogado.Cidade = leitor.GetString(6);
            UsuarioLogado.Estado = leitor.GetString(7);
            UsuarioLogado.Cpf = leitor.GetString(8);
            UsuarioLogado.Senha = leitor.GetString(9);
            UsuarioLogado.Celular = leitor.GetString(10);

            //fechando leitor
            leitor.Close();

            leitor.Close(); //fecha leitor
            conexao.Close(); //fecha conexao com BD
            Form telaPrincipal = Application.OpenForms["login"];
            //acessando o formulário aberto através da variável janelaPrincipal
            MenuStrip menuPrincipal = (MenuStrip)v.Controls[0];
            menuPrincipal.Items[0].Text = "Logout";
            menuPrincipal.Items[1].Visible = true;
            menuPrincipal.Items[2].Visible = true;
            menuPrincipal.Items[3].Visible = true;
            menuPrincipal.Items[4].Visible = true;
            menuPrincipal.Items[4].Text = UsuarioLogado.NomeCorrentista;
            menuPrincipal.Items[5].Visible = true;
            menuPrincipal.Items[6].Visible = true;
            menuPrincipal.Items[6].Text = UsuarioLogado.Contas[0].Id.ToString();



            MessageBox.Show($"Olá,{UsuarioLogado.NomeCorrentista}!\n" +
                $"Você foi logado na conta {UsuarioLogado.Contas[0].Id.ToString()}\n" +
                $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");
            //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +
            //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +
            //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");
            this.Close();


        }
    }
}