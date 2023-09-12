using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ui
{
    public class Conta

    {
        {
          public int Id { get; set; }
        public int IdCorrentista { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public double Saldo { get; set; }
        public string StatusConta { get; set; }
        public string Senha { get; set; }


        public Conta(int id, int IdCorrentista, DateTime DataAbertura, DateTime DataFechamento, double Saldo, string StatusConta, string Senha)
        {
            this.Id = id;
            this.IdCorrentista = IdCorrentista;
            this.Saldo = Saldo;
            this.StatusConta = StatusConta;
            this.DataAbertura = DataAbertura;
            this.DataFechamento = DataFechamento;
            this.Senha = Senha;
        }

       

}