using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Retiro
    {
        public int Id
        {
            get;
            set;
        }
        public int Id_Cheque
        {
            get;
            set;
        }
        public int Id_Cuenta
        {
            get;
            set;
        }
        public int Id_Moneda
        {
            get;
            set;
        }
        public int Importe
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
