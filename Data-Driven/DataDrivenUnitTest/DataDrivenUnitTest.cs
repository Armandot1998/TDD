using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenUnitTest
{
    [TestClass]
    public class CalculadoraDataDrivenUnitTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv", "data.csv", DataAccessMethod.Random)]
        public void SumarDosNumerosConDataSourceTest()
        {
            var number1 = Int32.Parse(TestContext.DataRow["number1"].ToString());
            var number2 = Int32.Parse(TestContext.DataRow["number2"].ToString());
            var expectedSum = Int32.Parse(TestContext.DataRow["sum"].ToString());

            var calculadora = new Calculadora();
            var actualresult = calculadora.SumarDosNumeros(number1, number2);

            Assert.AreEqual(expectedSum, actualresult);
        }

        [TestMethod]
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataFactorial.csv", "dataFactorial.csv", DataAccessMethod.Random)]
        public void FactorialDeUnNumeroConDataSourceTest()
        {
            var numero = Int32.Parse(TestContext.DataRow["Numero"].ToString());
            var esperado = Int32.Parse(TestContext.DataRow["Resultado"].ToString());

            var calculadora = new Calculadora();
            var actualresult = calculadora.Factorial(numero);

            Assert.AreEqual(esperado, actualresult);
        }

        [TestMethod]
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataFactorial.csv", "dataFactorial.csv", DataAccessMethod.Random)]
        public void FactorialRecursivoDeUnNumeroConDataSourceTest()
        {
            var numero = Convert.ToUInt32(TestContext.DataRow["Numero"].ToString());
            var esperado = Convert.ToUInt32(TestContext.DataRow["Resultado"].ToString());

            var calculadora = new Calculadora();
            var actualresult = calculadora.FactorialRecursivo(numero);

            Assert.AreEqual(esperado, actualresult);
        
        }
    }
}
