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
            //Cen�rio,
            
            string nome = "Fulano";
            string cpf = "1234567890";

            //A��o e Teste
            Cliente cliente = new Cliente();
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }

        [TestMethod]
        public void TestaConstrutorClienteComNome()
        {
            //Este c�digo verifica a crian��o de instancias da classe cliente informando o seu nome

            //Cen�rio
            string nome = "Fulano";
            var cliente = new Cliente(nome);

            //A��o e Teste
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }

        [TestMethod]
        public void TestaConstrutorClienteComNomeECPF()
        {
            //Este c�digo verifica a crian��o de instancias da classe cliente informando o seu nome

            //Cen�rio
            string nome = "Fulano";
            string cpf = "1234567890";
            var cliente = new Cliente(nome, cpf);

            //A��o e Teste
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }
        [TestMethod]
        public void TestaCpfDiferente11Digitos()
        {
            //Cen�rio
            string nome = "Fulano";
            string cpf = "1234567890";
            //var cliente = new Cliente(nome, cpf);

            //A��o e Teste
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Cliente(nome, cpf));
        }
    }
}