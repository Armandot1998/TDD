using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Ordenador.Test
{
    [TestClass]
    public class PruebaOrdenador2
    {
        [TestMethod]
        public void OrdenamientoCAB()
        {
            var primero = 3; // c
            var segundo = 1; // a
            var tercero = 2; // b

            var esperado1 = 1;
            var esperado2 = 2;
            var esperado3 = 3;

            Ordenador ordenaror = new Ordenador();
            List<int> actual = ordenaror.OrdenarAsc(primero, segundo, tercero);

            Assert.AreEqual(actual[0], esperado1);
            Assert.AreEqual(actual[1], esperado2);
            Assert.AreEqual(actual[2], esperado3);
        }

      
    }
}
