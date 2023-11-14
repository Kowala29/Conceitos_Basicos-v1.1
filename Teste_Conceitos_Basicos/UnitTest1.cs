using Conceitos_Basicos;

namespace Teste_Conceitos_Basicos
{
    [TestClass]
    public class UnitTest1
    {
        private int num1, num2, resultado;
        private double numf;

        [TestMethod]
        public void TestaSomaDoisNumerosInteros()
        {
            //Cenario
            InicializaVariaveis();
            Calculadora calculadora = new Calculadora();

            //Ação
            resultado = calculadora.Soma(num1, num2);

            //Verificação
            Assert.AreEqual(50, resultado);


        }
        [TestMethod]
        public void TestaSubtracaoDoisNumerosInteiros()
        {
            //Cenario
            InicializaVariaveis();

            var calculadora = new Calculadora();

            //Ação
            resultado = calculadora.Subtracao(num1, num2);

            //Verificação
            Assert.AreEqual(-10, resultado);
        }

        [TestMethod]
        public void VerificaNumeroPar()
        {
            //Cenario e Ação
            bool verifica = Calculadora.VerificaImpar(num1);
            InicializaVariaveis();

            //Verificação
            Assert.IsFalse(verifica);

        }

        [TestMethod]
        public void VerificaNumeroImpar()
        {
            //Cenario e Ação
            bool verifica = Calculadora.VerificaImpar(++num1);
            InicializaVariaveis();

            //Verificação
            Assert.IsTrue(verifica);

        }

        private void InicializaVariaveis()
        {
            num1 = 20;
            num2 = 30;
            numf = 5;
        }

        [TestMethod]
        public void Verifica_Fatorial() {
            //Cenário
            
            Fatorial fatorial = new Fatorial();
            InicializaVariaveis();
            //Ação e Verificãção

            Assert.AreEqual(120, fatorial.Fatorial_numero(numf));

        }
    }
}

// Teste para retornar o fatorial de um Número
//Teste para saber se um número é primo