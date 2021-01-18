using ConversorLetra.Controllers;
using NUnit.Framework;

namespace NUnitTestConversor
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
            string num1 = "5062";
            string esperado = "Cinco mil  Sesenta y Dos";

            FernandaController lit = new FernandaController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestNumeroPost()
        {

            //Arange=Preparaci�n
            string num1 = "6";
            string esperado = "Seis";

            FernandaController lit = new FernandaController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroPost(num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }
    }
}