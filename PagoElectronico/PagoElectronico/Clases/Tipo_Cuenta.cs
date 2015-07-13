using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Tipo_Cuenta
    {
        public int Id
        {
            get;
            set;
        }
        public string Descripcion_Tipo
        {
            get;
            set;
        }
        public int Costo_Suscripcion
        {
            get;
            set;
        }
        public int Duracion
        {
            get;
            set;
        }
        public int Costo_Transferencia
        {
            get;
            set;
        }
    }
}
