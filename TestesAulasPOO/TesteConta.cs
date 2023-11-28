using AulasPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAulasPOO
{
    [TestClass]
    public class TesteConta
    {
        [TestMethod]
        public void TestaDeposito()
        {
            //Cennário
            decimal saldoInicial = 1000;
            long numero = 1234;
            var conta1 = new Conta(numero, saldoInicial);

            //Ação
            conta1.Deposito(1000);

            //Teste
            Assert.AreEqual(2000, conta1.Saldo);
        }
        [TestMethod]
        public void TestaSaqueDentroDoSaldo() 
        {
            //Cennário
            decimal saldoInicial = 1000;
            long numero = 1234;
            var conta1 = new Conta(numero, saldoInicial);

            //Ação
            conta1.Saque(500);

            //Teste
            Assert.AreEqual(500, conta1.Saldo);
        }
    }
}
