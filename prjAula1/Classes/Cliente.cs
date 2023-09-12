using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAula1.Classes
{
    public class Cliente
    {
        
        private int _id;

        public string nomeCliente { get; set; }
        public int Id
        {
            get
            {
                return this._id;
            }
            set 
            {
                if(value <= 0) 
                {
                    throw new Exception("Id não pode ser menor que zero!");
                }
                else
                {
                    this._id = value;
                }
            }
        }

        public Cliente(string nomecliente, int id) 
        {
            this.nomeCliente = nomecliente;
            this.Id = id;
        }
    }
}
