using Ejercicio.C_LogicaNegocio;
using Ejercicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Operaciones
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Operaciones : System.Web.Services.WebService
{

    public Operaciones()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public bool IniciarSesion(Usuario objetoUsuario)
    {
        return AdministradorUsuarios.IniciarSesion(objetoUsuario);

    }

}
