using AulasPOO.Model;

namespace TestesAulasPOO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void  TestaConstrutorDefaultCliente()
        {
            //Este c�digo verifica a crian��o de instancias da classe cliente pelo construtor default
            var cliente = new Cliente();
            //Cen�rio, A��o e Teste
            Assert.IsInstanceOfType(new Cliente());


            /*
            string nome = "Eduardo";
            string endreco = "Rua Pregui�a";
            int telefone = 1224221;
            DateTime dataNascimento = 29/12/2004;
            */
        }

        [TestMethod]
        public void TestaConstrutorClienteComNome()
        {
            //Este c�digo verifica a crian��o de instancias da classe cliente informando o seu nome

        }
    }
}