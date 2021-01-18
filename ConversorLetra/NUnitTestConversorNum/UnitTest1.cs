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

            //Arange=Preparación
            string num1 = "6";
            string esperado = "Seis";

            FernandaController lit = new FernandaController();
            //Act=Ejecución
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
    }
}