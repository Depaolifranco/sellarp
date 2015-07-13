using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Cuenta
    {
        public int Id
        {
            get;
            set;
        }
        public int Id_Pais
        {
            get;
            set;
        }
        public int Id_Moneda
        {
            get;
            set;
        }
        public int Id_Cliente
        {
            get;
            set;
        }
        public int Id_Tipo_Cuenta
        {
            get;
            set;
        }
        public int Id_Estado
        {
            get;
            set;
        }
        public int Saldo
        {
            get;
            set;
        }
        public DateTime Fecha_Creacion
        {
            get;
            set;
        }
        public DateTime Fecha_Cierre
        {
            get;
            set;
        }
    }
}
