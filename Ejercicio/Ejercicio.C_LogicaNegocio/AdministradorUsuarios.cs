using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio.Entidades;
using Ejercicio.D_AccesoDatos;

namespace Ejercicio.C_LogicaNegocio
{
    public class AdministradorUsuarios
    {
        public static bool IniciarSesion(Usuario objetoUsuario)
        {
            return ManejadorDatos.IniciarSesion(objetoUsuario);

        }
    }
}
