using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Item_Factura
    {
        public int Id
        {
            get;
            set;
        }
        public int Id_Transferencia
        {
            get;
            set;
        }
        public int Id_Cuenta
        {
            get;
            set;
        }
        public int Id_Factura
        {
            get;
            set;
        }
        public int Id_Moneda
        {
            get;
            set;
        }
        public string Descripcion
        {
            get;
            set;
        }
        public int Importe
        {
            get;
            set;
        }
        public byte Facturado
        {
            get;
            set;
        }
    }
}
