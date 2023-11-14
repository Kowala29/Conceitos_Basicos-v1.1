using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conceitos_Basicos;

namespace Teste_Conceitos_Basicos
{
    [TestClass]
    public class Teste_Primo
    {
        [TestMethod]
        public void TestarPrimocomPrimo()
        {
            //Cenário
            int primo = 13;

            //Ação verificação
            Assert.IsTrue(Primo.Validar(primo));
        }

        [TestMethod]
        public void TestarPrimosemPrimo()
        {
            //Cenário
            int primo = 42;

            //Ação verificação
            Assert.IsFalse(Primo.Validar(primo));
        }
    }
}
