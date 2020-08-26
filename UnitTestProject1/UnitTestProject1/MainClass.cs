using System;

namespace Usuario
{
    public class verificarUsuario
    {
        public virtual Boolean VerificarPersona()
        {
            throw new NotImplementedException();
        }
    }

    public class ProcesosUsuario
    {
        public Boolean InsertarPersona(verificarUsuario objtmp)
        {
            if(objtmp.VerificarPersona() == true)
                return false;
            else
                return true;
        }
    }
}
