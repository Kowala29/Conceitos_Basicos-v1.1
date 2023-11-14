using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos {
    public class Fatorial {
        public double Fatorial_numero(double numero) {
            double i, fatorial;
            fatorial = numero;

            for (i = numero - 1; i >= 1; i--) {
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;
            }
            return fatorial;
        }
    }
}
