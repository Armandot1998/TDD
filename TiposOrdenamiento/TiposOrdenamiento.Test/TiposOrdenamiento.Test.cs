using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TiposOrdenamiento.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrdenamientoBurbuja()
        {
            int[] entrada = { 2, 1, 4, 3, 6, 5, 7 };

            int[] esperado = {1, 2, 3, 4, 5, 6, 7 };

            TiposOrdenamiento tiposordenamiento = new TiposOrdenamiento();
            List<int> actual = tiposordenamiento.OrdenarBusbuja(entrada);

            Assert.AreEqual(esperado[0], actual[0]);

        }
    }
}
