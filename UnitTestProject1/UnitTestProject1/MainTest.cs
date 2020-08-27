using Microsoft.VisualStudio.TestTools.UnitTesting;
using Usuario;
using Moq;

namespace PruebaUnitariaProcesosUsuaro
{
    [TestClass]
    public class PrimerMockTest
    {
        [TestMethod]
        public void UsuarioNoExistenteIsTrue()
        {
            Mock<UsuarioControl> verificacion = new Mock<UsuarioControl>();
            verificacion.Setup(x => x.VerificarUsuario()).Returns(false);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsTrue(obje.InsertarUsuario(verificacion.Object));
        }

        [TestMethod]
        public void InsertarUsuarioExistenteIsFalse()
        {
            Mock<UsuarioControl> verificacion = new Mock<UsuarioControl>();
            verificacion.Setup(x => x.VerificarUsuario()).Returns(true);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsFalse(obje.InsertarUsuario(verificacion.Object));
        }

        [TestMethod]
        public void CambiarClaveSinConfirmarMail()
        {
            Mock<UsuarioControl> verificacion = new Mock<UsuarioControl>();
            verificacion.Setup(x => x.ConfirmarMail()).Returns(false);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsFalse(obje.CambiarClaveUsuario(verificacion.Object));
        }

        [TestMethod]
        public void CambiarClaveConfirmandoMail()
        {
            Mock<UsuarioControl> verificacion = new Mock<UsuarioControl>();
            verificacion.Setup(x => x.ConfirmarMail()).Returns(true);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsTrue(obje.CambiarClaveUsuario(verificacion.Object));
        }

        [TestMethod]
        public void LogearUsuarioCorrecto()
        {
            Mock<UsuarioControl> verificacionUsuario = new Mock<UsuarioControl>();
            Mock<UsuarioControl> verificacionClave = new Mock<UsuarioControl>();
            verificacionUsuario.Setup(x => x.VerificarUsuario()).Returns(true);
            verificacionClave.Setup(x => x.VerificarClaveUsuario()).Returns(true);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsTrue(obje.LogeoUsuario(verificacionUsuario.Object, verificacionClave.Object));
        }

        [TestMethod]
        public void LogearUsuarioNoExistente()
        {
            Mock<UsuarioControl> verificacionUsuario = new Mock<UsuarioControl>();
            Mock<UsuarioControl> verificacionClave = new Mock<UsuarioControl>();
            verificacionUsuario.Setup(x => x.VerificarUsuario()).Returns(false);
            verificacionClave.Setup(x => x.VerificarClaveUsuario()).Returns(false);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsFalse(obje.LogeoUsuario(verificacionUsuario.Object, verificacionClave.Object));
        }

        [TestMethod]
        public void LogearUsuarioExistenteConClaveErronea()
        {
            Mock<UsuarioControl> verificacionUsuario = new Mock<UsuarioControl>();
            Mock<UsuarioControl> verificacionClave = new Mock<UsuarioControl>();
            verificacionUsuario.Setup(x => x.VerificarUsuario()).Returns(true);
            verificacionClave.Setup(x => x.VerificarClaveUsuario()).Returns(false);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsFalse(obje.LogeoUsuario(verificacionUsuario.Object , verificacionClave.Object));
        }

        [TestMethod]
        public void ResetearClaveConfirmandoMail()
        {
            Mock<UsuarioControl> verificacionUsuario = new Mock<UsuarioControl>();
            Mock<UsuarioControl> verificacionMail = new Mock<UsuarioControl>();
            verificacionUsuario.Setup(x => x.VerificarUsuario()).Returns(true);
            verificacionMail.Setup(x => x.ConfirmarMail()).Returns(true);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsTrue(obje.RecuperarClaveUsuario(verificacionUsuario.Object, verificacionMail.Object));
        }

        [TestMethod]
        public void ResetearClaveSinConfirmarMail()
        {
            Mock<UsuarioControl> verificacionUsuario = new Mock<UsuarioControl>();
            Mock<UsuarioControl> verificacionMail = new Mock<UsuarioControl>();
            verificacionUsuario.Setup(x => x.VerificarUsuario()).Returns(true);
            verificacionMail.Setup(x => x.ConfirmarMail()).Returns(false);

            ProcesosUsuario obje = new ProcesosUsuario();
            Assert.IsFalse(obje.RecuperarClaveUsuario(verificacionUsuario.Object, verificacionMail.Object));
        }
    }
}
