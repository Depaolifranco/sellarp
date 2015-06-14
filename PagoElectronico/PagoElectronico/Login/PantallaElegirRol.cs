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
    public partial class PantallaElegirRol : Form
    {
        public PantallaElegirRol()
        {
            InitializeComponent();
            LlenarListaDeRoles();
        }

        void LlenarListaDeRoles()
        {

        }

        private void PantallaElejirRol_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxRoles.Text == "Administrador")
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
                PagoElectronico.Funciones.PantallaFunciones funcionesUser = new PagoElectronico.Funciones.PantallaFunciones();
                funcionesUser.buttonConsulta.Visible = true;
                funcionesUser.buttonDeposito.Visible = true;
                funcionesUser.buttonRetiros.Visible = true;
                funcionesUser.buttonTransferencias.Visible = true;

                funcionesUser.Show();
                this.Hide();
            }
        }
    }
}
