using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Login
    {
        public int Id
        {
            get;
            set;
        }
        public int Id_Usuario
        {
            get;
            set;
        }
        public string Usuario
        {
            get;
            set;
        }
        public byte Correcto
        {
            get;
            set;
        }
        public DateTime Fecha
        {
            get;
            set;
        }
    }
}
