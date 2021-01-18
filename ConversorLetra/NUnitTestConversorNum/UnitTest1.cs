using NUnit.Framework;

namespace NUnitTestConversorNum
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNumeroGet()
        {

            //Arange=Preparaci�n
            string num1 = "6";
            string esperado = "Seis";

            FernandaController lit = new FernandaController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }
    }
}