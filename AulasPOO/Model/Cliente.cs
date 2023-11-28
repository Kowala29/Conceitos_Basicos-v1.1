using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model {
    public class Cliente {
        //Complemente a classe cliente conforme solicitado em program
        private string _nome;
        private string _cpf;
        //private string _endereco;
        //private int _telefone;
        //private DateTime _dataNascimento;

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

        public string Cpf { 
            get{ 
                return _cpf;
            } 
            set { 
                _cpf = value;
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

        public Cliente(string nome, string cpf)
        {
            if(cpf.Length != 11)
            {
                throw new ArgumentOutOfRangeException("CPF deve ter 11 Dígitos");
            }
            _nome = nome;
            _cpf = cpf;
            
        }

        public Cliente() 
        {

        }
    }
}
