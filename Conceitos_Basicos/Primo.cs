using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    public class Primo
    { 
        public static bool Validar(int primo)
        {
            int resultado = 2;
                for (int i = 2; i <= (primo / 2); i++)
                {
                    if(primo % i == 0)
                    {
                        resultado++;
                    }
                }
                if (resultado == 2)
                {
                return true;
                }
                return false;
        }
    }
}
