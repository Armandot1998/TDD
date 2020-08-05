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

        [TestMethod]
        public void OrdenamientoShellDouble()
        {
            double[] entrada = { 2.4, 1.6, 4.7, 3.9, 6.1, 5.9 };

            double[] esperado = { 1.6, 2.4, 3.9, 4.7, 5.9, 6.1 };

            OrdenamientoShell ordenamientoshell = new OrdenamientoShell();
            double[] actual = ordenamientoshell.OrdenarShellDouble(entrada);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
        }

        [TestMethod]
        public void OrdenamientoQuickInt()
        {
            int[] entrada = { 1, 2, 4, 3, 0, -1, 5, 7, 8, 6 };
            int[] esperado = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int primero = 0;
            int ultimo = entrada.Length - 1;

            OrdenamientoQuickInt ordenamientoQuick = new OrdenamientoQuickInt();
            int[] actual = ordenamientoQuick.OrdenarQuick(entrada, primero, ultimo);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
            Assert.AreEqual(esperado[6], actual[6]);
            Assert.AreEqual(esperado[7], actual[7]);
            Assert.AreEqual(esperado[8], actual[8]);
            Assert.AreEqual(esperado[9], actual[9]);
        }

        [TestMethod]
        public void OrdenamientoQuickDouble()
        {
            double[] entrada = { 10.4, 64.1, 7.9, 99.5, 32.6, 18.3, 0 };
            double[] esperado = { 0, 7.9, 10.4, 18.3, 32.6, 64.1, 99.5 };
            int primero = 0;
            int ultimo = entrada.Length - 1;

            OrdenamientoQuickDouble ordenamientoQuick = new OrdenamientoQuickDouble();
            double[] actual = ordenamientoQuick.OrdenarQuick(entrada, primero, ultimo);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
        }

        [TestMethod]
        public void OrdenamientoHeapDouble()
        {
            double[] entrada = { 10.4, 64.1, 7.9, 99.5, 32.6, 18.3, 0 };
            double[] esperado = { 0, 7.9, 10.4, 18.3, 32.6, 64.1, 99.5 };

            OrdenamientoHeapDouble ordenamientoHeap = new OrdenamientoHeapDouble();
            double[] actual = ordenamientoHeap.OrdenarHeapDouble(entrada);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
        }

        [TestMethod]
        public void OrdenamientoHeapInt()
        {
            int[] entrada = { 10, 64, 7, 99, 32, 18, 0 };
            int[] esperado = { 0, 7, 10, 18, 32, 64, 99 };

            OrdenamientoHeapInt ordenamientoHeap = new OrdenamientoHeapInt();
            int[] actual = ordenamientoHeap.OrdenarHeapInt(entrada);

            Assert.AreEqual(esperado[0], actual[0]);
            Assert.AreEqual(esperado[1], actual[1]);
            Assert.AreEqual(esperado[2], actual[2]);
            Assert.AreEqual(esperado[3], actual[3]);
            Assert.AreEqual(esperado[4], actual[4]);
            Assert.AreEqual(esperado[5], actual[5]);
        }



    }
}
