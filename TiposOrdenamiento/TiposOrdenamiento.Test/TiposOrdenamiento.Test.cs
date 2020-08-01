using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TiposOrdenamiento.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrdenamientoBubbleInt()
        {
            int[] entrada = { 2, 1, 4, 3, 6, 5};

            int[] esperado = {1, 2, 3, 4, 5, 6 };

            OrdenamientoBubble ordenamientobubble = new OrdenamientoBubble();
            int[] actual = ordenamientobubble.OrdenarBubbleInt(entrada);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
        }

        [TestMethod]
        public void OrdenamientoBubbleDouble()
        {
            double[] entrada = { 2.4, 1.6, 4.7, 3.9, 6.1, 5.9 };

            double[] esperado = { 1.6, 2.4, 3.9, 4.7, 5.9, 6.1 };

            OrdenamientoBubble ordenamientobubble = new OrdenamientoBubble();
            double[] actual = ordenamientobubble.OrdenarBubbleDouble(entrada);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
        }

        [TestMethod]
        public void OrdenamientoShellInt()
        {
            int[] entrada = { 2, 1, 4, 3, 6, 5 };

            int[] esperado = { 1, 2, 3, 4, 5, 6 };

            OrdenamientoShell ordenamientoshell = new OrdenamientoShell();
            int[] actual = ordenamientoshell.OrdenarShellInt(entrada);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
        }
    }
}
