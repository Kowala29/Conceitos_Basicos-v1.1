using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model
{
    //Crie os códigos de Teste para cada metodo construtor de conta
    //permita também criar contas informando apenas o número ou apenas o saldo
    public class Conta
    {
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
            public decimal Saldo { get 
            { 
                return _saldo;
            }
            private set
            {
                _saldo = value;
            } 
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
