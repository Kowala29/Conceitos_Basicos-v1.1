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

            //A��o
            resultado = calculadora.Soma(num1, num2);

            //Verifica��o
            Assert.AreEqual(50, resultado);


        }
        [TestMethod]
        public void TestaSubtracaoDoisNumerosInteiros()
        {
            //Cenario
            InicializaVariaveis();

            var calculadora = new Calculadora();

            //A��o
            resultado = calculadora.Subtracao(num1, num2);

            //Verifica��o
            Assert.AreEqual(-10, resultado);
        }

        [TestMethod]
        public void VerificaNumeroPar()
        {
            //Cenario e A��o
            bool verifica = Calculadora.VerificaImpar(num1);
            InicializaVariaveis();

            //Verifica��o
            Assert.IsFalse(verifica);

        }

        [TestMethod]
        public void VerificaNumeroImpar()
        {
            //Cenario e A��o
            bool verifica = Calculadora.VerificaImpar(++num1);
            InicializaVariaveis();

            //Verifica��o
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
            //Cen�rio
            
            Fatorial fatorial = new Fatorial();
            InicializaVariaveis();
            //A��o e Verific���o

            Assert.AreEqual(120, fatorial.Fatorial_numero(numf));

        }
    }
}

// Teste para retornar o fatorial de um N�mero
//Teste para saber se um n�mero � primo