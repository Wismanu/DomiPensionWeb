using CapaAccesoDatos;
using CapaEntidades;
using System;

namespace CapaLogicaNegocio
{
    public class N_Login
    {
        private D_Login objDato = new D_Login();

        public bool N_VerifyLogin(E_Login usuario, ref Exception ex)
        {
            try
            {
                return objDato.D_VerifyLogin(usuario, ref ex);
            }
            catch (Exception e)
            {
                ex = e;
                return false;
            }
        }
    }
}
