using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Ordenamiento.Test
{
    [TestClass]
    public class PruebaOrdenamiento
    {
        [TestMethod]
        public void OrdenamientoABC()
        {
            var primero = 1; //a
            var segundo = 2; //b
            var tercero = 3; //c

            var esperado1 = 1;
            var esperado2 = 2;
            var esperado3 = 3;

            //Ejecutar -- Act
            Ordenar ordenar = new Ordenar();
            List<int> actual = ordenar.OrdenarAsc(primero, segundo, tercero);

            //Comprobar -- Assert

            Assert.AreEqual(esperado1, actual[0]);
            Assert.AreEqual(esperado2, actual[1]);
            Assert.AreEqual(esperado3, actual[2]);
        }

        [TestMethod]
        public void OrdenamientoACB()
        {
            var primero = 1; //a
            var segundo = 3; //c
            var tercero = 2; //b

            var esperado1 = 1;
            var esperado2 = 2;
            var esperado3 = 3;

            //Ejecutar -- Act
            Ordenar ordenar = new Ordenar();
            List<int> actual = ordenar.OrdenarAsc(primero, segundo, tercero);

            //Comprobar -- Assert

            Assert.AreEqual(esperado1, actual[0]);
            Assert.AreEqual(esperado2, actual[1]);
            Assert.AreEqual(esperado3, actual[2]);
        }
    }
}
