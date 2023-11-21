using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model {
    public class Cliente {
        //Complemente a classe cliente conforme solicitado em program
        private string _nome;
        private string _endereco;
        private int _telefone;
        private DateTime _dataNascimento;

        public string Nome {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string endereco { 
            get{ 
                return _endereco;
            } 
            set { 
                _endereco = value;
            } 
        }

        public static int IdadeCliente(DateTime dataNacimento) {
            int idade = DateTime.Now.Year - dataNacimento.Year;
            if (DateTime.Now.DayOfYear < dataNacimento.DayOfYear) {
                idade = idade - 1;
            }
            return idade;
        }
        public Cliente(string nome)
        {
            _nome = nome;
        }

        public Cliente()
        {

        }
    }
}
