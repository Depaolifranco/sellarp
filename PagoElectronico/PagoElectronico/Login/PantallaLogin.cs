using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Login
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //try
           // {
                /*
                 * bool existe VerificarUsuario();
                 * if(existe)
                 * {
                 *  AbrirFunciones(); //Si tiene mas de un rol abre PantallaElegirRol, sino la de cliente
                 * }
                 * else
                 * {
                 *  MessageBox.Show("Usuario o contraseña incorrectos");
                 * }
                */
                if (textBoxUser.Text == "admin")
                {
                    if (textBoxPass.Text == "w23e")
                    {
                        PagoElectronico.Funciones.PantallaFunciones funciones = new PagoElectronico.Funciones.PantallaFunciones();
                        funciones.Show();
                        this.Hide();
                        funciones.buttonABMCliente.Visible = true;
                        funciones.buttonABMCuenta.Visible = true;
                        funciones.buttonABMRol.Visible = true;
                        funciones.buttonABMUsuario.Visible = true;
                        funciones.buttonConsulta.Visible = true;
                        funciones.buttonDeposito.Visible = true;
                        funciones.buttonFacturacion.Visible = true;
                        funciones.buttonListados.Visible = true;
                        funciones.buttonRetiros.Visible = true;
                        funciones.buttonTransferencias.Visible = true;
                    }
                    
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                else
                {
                    if (textBoxUser.Text == "user")
                    {
                        PagoElectronico.Funciones.PantallaFunciones funcionesUser = new PagoElectronico.Funciones.PantallaFunciones();
                        funcionesUser.buttonConsulta.Visible = true;
                        funcionesUser.buttonDeposito.Visible = true;
                        funcionesUser.buttonRetiros.Visible = true;
                        funcionesUser.buttonTransferencias.Visible = true;
                        
                        funcionesUser.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto");
                    }
                }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void PantallaLogin_Load(object sender, EventArgs e)
        {

        }
            
          //  catch (Exception ex)
         //   {
          //      MessageBox.Show(ex.Message);
         //   }

            /*  public Boolean VerificarUsuario();
             *  { 
                 * string datosConexion = "datasource = localhost;
                 *                          port = 3306;
                 *                          username = root;
                 *                          password = root";
                 * MySqlConnection conexion = new MySqlConnection(datosConexion);
                 * 
                 * MySqlCommand ComandoSelect = new MySqlCommand("select * from GD1C2015.SELLARP.Usuario where Username = '"+ this.textBoxUser.Text +" and Contraseña = '"+ textBoxPass.Text +"' ;", conexion);
                 *
                 * MySqlDataReader myReader;
                 * conexion.Open();
                 * myReader = ComandoSelect.ExecuteReader();
                 * int contador = 0;
                 * while (myReader.Read())
                 * {
                 *      contador = contador + 1;
                 * }
                 * if (contador = 1) //Encontro ese usuario y contraseña
             *      {
             *          return true;
             *      }
             *      else
             *      {
             *          return false;
             *      }
             *  }
             *  
             * public void AbrirFunciones()
             * {
             *  if(cantidadRoles > 1)
             *  {
             *      PantallaElejirRol roles = new PantallaElegirRol();
                        roles.Show();
                        this.Hide();
             *  }
             *  PagoElectronico.Funciones.PantallaFunciones funciones = new PagoElectronico.Funciones.PantallaFunciones();
                        funciones.Show();
                        this.Hide();
             * }
             */
        }
        
     
}
    