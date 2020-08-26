using Microsoft.VisualStudio.TestTools.UnitTesting;
using Usuario;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class PrimerMockTest
    {
        [TestMethod]
        public void UsuarioExistente()
        {
            Mock<verificarUsuario> chk = new Mock<verificarUsuario>();
            chk.Setup(x => x.VerificarPersona()).Returns(true);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.AreEqual(obje.InsertarPersona(chk.Object), false);
        }
        
        [TestMethod]
        public void UsuarioNoExistente()
        {
            Mock<verificarUsuario> chk = new Mock<verificarUsuario>();
            chk.Setup(x => x.VerificarPersona()).Returns(false);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.AreEqual(obje.InsertarPersona(chk.Object), true);
        }
    }
}
