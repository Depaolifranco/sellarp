using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class Listado_Seleccion_Baja : Form
    {
        public Listado_Seleccion_Baja()
        {
            InitializeComponent();
        }

// Validar que se haya elegido una cuenta a cerrar

        private bool ValidarCamposCompletos()
        {
            StringBuilder builder = new StringBuilder("");

            if (this.comboSeleccioneCtaBaja.SelectedIndex < 0)
                builder.AppendLine("Cuenta a Cerrar");

            if (builder.Length == 0)
                return true;
            else
            {
                MessageBox.Show("Los siguientes campos requieren un valor:\r\n" + builder.ToString(), "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

// Validar que no hayan cargos previos sin facturar

        private bool ValidarFacturacion()
        {
            return true;//TODO
        }

        private bool RealizarValidaciones()
        {
            return (this.ValidarFacturacion() && this.ValidarCamposCompletos());
        }

        private void buttonCerrarCta_Click(object sender, EventArgs e)
        {
            if (RealizarValidaciones())
            { 
            // TODO Cerrar Cuenta
            }
        }

        private void Listado_Seleccion_Baja_Load(object sender, EventArgs e)
        {

        }

    }
}
