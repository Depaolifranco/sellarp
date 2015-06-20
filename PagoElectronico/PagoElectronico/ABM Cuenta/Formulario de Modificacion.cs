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
    public partial class FormFormularioModif : Form
    {
        public FormFormularioModif()
        {
            InitializeComponent();
        }

//      Valido que todos los campos hayan sido completados.

        private bool ValidarCamposCompletos()
        {
            StringBuilder builder = new StringBuilder("");

            if (this.comboBoxTipoCtaModif.SelectedIndex < 0)
                builder.AppendLine("Nuevo tipo de Cuenta");

            if (builder.Length == 0)
                return true;
            else
            {
                MessageBox.Show("Los siguientes campos requieren un valor:\r\n" + builder.ToString(), "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

//      Valido que el tipo de cuenta Actual sea distinto al Tipo de Cuenta por el que quiero cambiar.

        private bool ValidarQueSeElijaOtroTipoDeCuenta()
        {
            if (this.comboBoxTipoCtaModif.SelectedValue.Equals(this.textBoxTipoCtaActual.SelectedText))
                return true;
            else
            {
                MessageBox.Show("La modificacion es invalida, debe sleccionar un tipo de cuenta distinto del actual \n", "Modificacion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

//      Agrupo las validaciones anteriores para luego realizarlas a la hora de impactar la BD.

        private bool ValidarCampos()
        {
            return (ValidarCamposCompletos() && ValidarQueSeElijaOtroTipoDeCuenta()); 
        }

//      Vuelvo al Listado de Seleccion de Cuentas a Modificar.

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ABM_Cuenta.FormModifTipoCta volverA = new FormModifTipoCta();
            volverA.Show();
            this.Close();
        }

//      Guardo las modificaciones en la Base de Datos.

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
            }
        }

        private void FormFormularioModif_Load(object sender, EventArgs e)
        {

        }
    }
}
