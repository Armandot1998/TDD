using Data_Driven.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Data_Driven_Test
{

    [TestClass]
    public class DataDrivenTest
    {
        [DataSource(@" Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
            DeploymentItem("data.csv")]
        [TestMethod()]
        public void SumaDosNumerosTest()
        {
            var calculadora = new Calculadora();

            var number1 = Int32.Parse(TestContext.DataRow['number1'].ToString());
        }
    }
}
