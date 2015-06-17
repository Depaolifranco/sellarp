using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PagoElectronico
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source = SQLSERVER2008; Initial Catalog = GD1C2015; User Id=gd; Password=gd2015");
            Conn.Open();

            return Conn;
        }
    }
}
