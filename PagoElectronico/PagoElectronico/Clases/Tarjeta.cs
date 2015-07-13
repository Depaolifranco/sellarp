using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Tarjeta
    {
        public int Id
        {
            get;
            set;
        }
        public string Id_Tarjeta
        {
            get;
            set;
        }
        public int Id_Cliente
        {
            get;
            set;
        }
        public int Id_Emisor
        {
            get;
            set;
        }
        public DateTime Fecha_Emision
        {
            get;
            set;
        }
        public DateTime Fecha_Vencimiento
        {
            get;
            set;
        }
        public string Codigo_Seguridad
        {
            get;
            set;
        }
    }
}
