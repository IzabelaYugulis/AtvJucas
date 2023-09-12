using System.ComponentModel;
using Ui;

namespace Ui
{
    public static class UsuarioLogado
    {
        public static int Id { get; set; }
        public static string? NomeCorrentista { get; set; }
        public static DateTime? DataNascimento { get; set; }
        public static string? Logradouro { get; set; }
        public static string? Numero { get; set; }
        public static string? Complemento { get; set; }
        public static string? Cidade { get; set; }
        public static string? Estado { get; set; }
        public static string? Cpf { get; set; }
        public static string? Celular { get; set; }
        public static string? Senha { get; set; }



        public static List<Conta> Contas = new List<Conta>();



        public static void Deslogar()
        {
            UsuarioLogado.Id = 0;
            UsuarioLogado.NomeCorrentista = String.Empty;
            UsuarioLogado.DataNascimento = null;
            UsuarioLogado.Logradouro = String.Empty;
            UsuarioLogado.Numero = String.Empty;
            UsuarioLogado.Complemento = null;
            UsuarioLogado.Cidade = String.Empty;
            UsuarioLogado.Estado = String.Empty;
            UsuarioLogado.Cpf = String.Empty;
            UsuarioLogado.Celular = String.Empty;
            UsuarioLogado.Senha = String.Empty;
            UsuarioLogado.Contas.Clear();
        }
    }
}