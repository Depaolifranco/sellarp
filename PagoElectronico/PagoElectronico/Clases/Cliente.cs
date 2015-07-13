using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Clases
{
    class Cliente
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
        public int Id_Pais
        {
            get;
            set;
        }
        public byte Estado
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }
        public string Apellido
        {
            get;
            set;
        }
        public int Tipo_Documento
        {
            get;
            set;
        }
        public string Descripcion_Documento
        {
            get;
            set;
        }
        public int Nro_Dni
        {
            get;
            set;
        }
        public string Calle_Domicilio
        {
            get;
            set;
        }
        public int Nro_Domicilio
        {
            get;
            set;
        }
        public int Piso
        {
            get;
            set;
        }
        public string Depto
        {
            get;
            set;
        }
        public string Mail
        {
            get;
            set;
        }
        public DateTime Fecha_Nacimiento
        {
            get;
            set;
        }
    }
}
