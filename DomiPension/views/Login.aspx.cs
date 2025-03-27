using System;
using CapaEntidades;
using CapaLogicaNegocio;

namespace DomiPension.views
{ 
    public partial class Login : System.Web.UI.Page
    {        
        private readonly N_Login negocioLogin = new N_Login();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text;
            string clave = txtPassword.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
            {
                E_Login usuarioEntidad = new E_Login
                {
                    Log_Name = usuario,
                    Log_Password = clave
                };

                Exception ex = null;
                bool loginExitoso = negocioLogin.N_VerifyLogin(usuarioEntidad, ref ex);

                if (loginExitoso)
                {
                    Session["Usuario"] = usuario;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblError.Text = "Usuario o contraseña incorrectos";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Por favor, ingrese los datos requeridos";
                lblError.Visible = true;
            }
        }
    }
}