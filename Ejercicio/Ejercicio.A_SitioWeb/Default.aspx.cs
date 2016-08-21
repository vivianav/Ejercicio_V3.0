using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        try
        {
            Proxy.Operaciones servicio = new Proxy.Operaciones();

            Proxy.Usuario objeto = new Proxy.Usuario();

            objeto.Nombre = this.txtUsuario.Text;
            objeto.Clave = this.txtClave.Text;

            if (servicio.IniciarSesion(objeto) == true)
            {

                Response.Redirect("Bienvenida.aspx");
            }
            else
            {

                lblMensajes.Text = "Usuario o clave invalido";

            }
        }
        catch (Exception excepcion)
        {

            lblMensajes.Text = "Ha ocurrido un error iniciando sesión.";
        }



    }
}