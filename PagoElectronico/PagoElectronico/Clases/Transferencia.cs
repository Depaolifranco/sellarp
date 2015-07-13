using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Transferencia
    {
        public int Id
        {
            get;
            set;
        }
        public int CuentaOrigen
        {
            get;
            set;
        }
        public int CuentaDestino
        {
            get;
            set;
        }
        public DateTime Fecha
        {
            get;
            set;
        }
        public int Importe
        {
            get;
            set;
        }
        public int Moneda
        {
            get;
            set;
        }
    }
}
