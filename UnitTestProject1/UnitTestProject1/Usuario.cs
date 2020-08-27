using System;

namespace Usuario
{
    public class UsuarioControl
    {
        public virtual Boolean VerificarUsuario()
        {
            throw new NotImplementedException();
        }

        public virtual Boolean ConfirmarMail()
        {
            throw new NotImplementedException();
        }

        public virtual Boolean VerificarClaveUsuario()
        {
            throw new NotImplementedException();
        }
    }

    public class ProcesosUsuario
    {
        public Boolean InsertarUsuario(UsuarioControl objtmp)
        {
            return objtmp.VerificarUsuario() != true;
        }

        public Boolean CambiarClaveUsuario(UsuarioControl objtmp)
        {
            return objtmp.ConfirmarMail() != false;
        }

        public Boolean LogeoUsuario(UsuarioControl objtmp, UsuarioControl objtclave)
        {
            if (objtmp.VerificarUsuario() == true)
                return objtclave.VerificarClaveUsuario() == true;
            else
                return false;
        }

        public Boolean RecuperarClaveUsuario(UsuarioControl objtmp, UsuarioControl objtmail)
        {
            if (objtmp.VerificarUsuario() == true)
                return objtmail.ConfirmarMail() == true; 
            else
                return false;
        }
    }
}
