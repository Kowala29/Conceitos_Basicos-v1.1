using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model
{
    //Crie os códigos de Teste para cada metodo construtor de conta
    //permita também criar contas informando apenas o número ou apenas o saldo
    public class Conta
    {

        private Cliente _titular;
        public Cliente Titular {
            get 
            {
                return _titular;
            }
            set 
            {
                _titular = value;
            }
        }
        private long _numeroConta;
        public long NumeroConta {
        get { 
            return _numeroConta;
        }
        private set { 
            _numeroConta = value;
        } 
        }

        private decimal _saldo;
        public decimal Saldo { 
        get 
        { 
            return _saldo;
        }
        private set
        {
            _saldo = value;
        }

        }

        public decimal Deposito(decimal deposito)
        {
            return Saldo = deposito + Saldo;
        }

        public decimal Saque(decimal saque)
        {
            if (saque > Saldo)
            {
                Console.WriteLine("Você não pode Sacar essa quantia");
            }
            return Saldo = Saldo - saque;
        }

        public Conta(long numeroConta, decimal saldo)
        {
            _numeroConta = numeroConta;
            _saldo = saldo;
        }
        public Conta()
        {

        }
        
    }
}
