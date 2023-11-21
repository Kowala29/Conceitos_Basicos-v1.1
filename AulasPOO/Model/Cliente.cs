using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model {
    public class Cliente {
        public static int IdadeCliente(DateTime dataNacimento) {
            int idade = DateTime.Now.Year - dataNacimento.Year;
            if (DateTime.Now.DayOfYear < dataNacimento.DayOfYear) {
                idade = idade - 1;
            }
            return idade;
        }
    }
}
