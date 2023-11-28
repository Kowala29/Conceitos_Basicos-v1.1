using AulasPOO.Model;

namespace TestesAulasPOO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void  TestaConstrutorDefaultCliente()
        {
            //Este código verifica a crianção de instancias da classe cliente pelo construtor default
            //Cenário,
            
            string nome = "Fulano";
            string cpf = "1234567890";

            //Ação e Teste
            Cliente cliente = new Cliente();
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }

        [TestMethod]
        public void TestaConstrutorClienteComNome()
        {
            //Este código verifica a crianção de instancias da classe cliente informando o seu nome

            //Cenário
            string nome = "Fulano";
            var cliente = new Cliente(nome);

            //Ação e Teste
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }

        [TestMethod]
        public void TestaConstrutorClienteComNomeECPF()
        {
            //Este código verifica a crianção de instancias da classe cliente informando o seu nome

            //Cenário
            string nome = "Fulano";
            string cpf = "1234567890";
            var cliente = new Cliente(nome, cpf);

            //Ação e Teste
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }
        [TestMethod]
        public void TestaCpfDiferente11Digitos()
        {
            //Cenário
            string nome = "Fulano";
            string cpf = "1234567890";
            //var cliente = new Cliente(nome, cpf);

            //Ação e Teste
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Cliente(nome, cpf));
        }
    }
}