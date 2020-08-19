using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenUnitTest
{
    [TestClass]
    public class DataDrivenUnitTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv", "data.csv", DataAccessMethod.Sequential)]
        public void SumarDosNumerosConDataSourceTest()
        {
            var calculadora = new Calculadora();

            var number1 = Int32.Parse(TestContext.DataRow["number1"].ToString());
            var number2 = Int32.Parse(TestContext.DataRow["number2"].ToString());
            var expectedSum = Int32.Parse(TestContext.DataRow["sum"].ToString());

            var actualresult = calculadora.Suma(number1, number2);
            Assert.AreEqual(expectedSum, actualresult);
        }

        [TestMethod]
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataFactorial.csv", "dataFactorial.csv", DataAccessMethod.Sequential)]
        public void FactorialDeUnNumeroConDataSourceTest()
        {
            var calculadora = new Calculadora();

            var numero = Int32.Parse(TestContext.DataRow["Numero"].ToString());
            var esperado = Int32.Parse(TestContext.DataRow["Resultado"].ToString());

            var actualresult = calculadora.Factorial(numero);
            Assert.AreEqual(esperado, actualresult);
        }
    }
}
