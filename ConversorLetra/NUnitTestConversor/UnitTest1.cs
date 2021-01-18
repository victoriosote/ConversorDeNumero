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

            //Arange=Preparación
            string num1 = "5062";
            string esperado = "Cinco mil  Sesenta y Dos";

            FernandaController lit = new FernandaController();
            //Act=Ejecución
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestNumeroPost()
        {

            //Arange=Preparación
            string num1 = "6";
            string esperado = "Seis";

            FernandaController lit = new FernandaController();
            //Act=Ejecución
            string resultado = lit.NumeroPost(num1);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
    }
}