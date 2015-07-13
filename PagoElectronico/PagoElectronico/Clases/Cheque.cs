using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Cheque
    {
        public int Id
        {
            get;
            set;
        }
        public int Id_Banco
        {
            get;
            set;
        }
        public int Id_Moneda
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
        public string Nombre_Librador
        {
            get;
            set;
        }
    }
}
