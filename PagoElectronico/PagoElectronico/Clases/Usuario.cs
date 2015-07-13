using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Usuario
    {
        public int Id
        {
            get;
            set;
        }
        public string Username
        {
            get;
            set;
        }
        public string Contraseña
        {
            get;
            set;
        }
        public DateTime Fecha_Creacion
        {
            get;
            set;
        }
        public DateTime Ultima_Fecha_Modif
        {
            get;
            set;
        }
        public string Pregunta_Secreta
        {
            get;
            set;
        }
        public string Respuesta_Secreta
        {
            get;
            set;
        }
    }
}
