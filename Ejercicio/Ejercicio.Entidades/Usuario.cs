using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.Entidades
{
    public class Usuario
    {
        private string nombre = string.Empty;
        private string clave = string.Empty;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }
    }
}
