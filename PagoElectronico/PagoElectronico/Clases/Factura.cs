using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Factura
    {
        public int Id
        {
            get;
            set;
        }
        public int Id_Cliente
        {
            get;
            set;
        }
        public DateTime Fecha
        {
            get;
            set;
        }
        public int Total
        {
            get;
            set;
        }
        public int Id_Moneda
        {
            get;
            set;
        }
    }
}
