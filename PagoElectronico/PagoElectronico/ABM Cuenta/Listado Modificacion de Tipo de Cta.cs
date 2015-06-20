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
    public partial class FormModifTipoCta : Form
    {
        public FormModifTipoCta()
        {
            InitializeComponent();
        }

        private void labelNroCuenta_Click(object sender, EventArgs e)
        {

        }

//      Valido que el cliente haya seleccionado una cuenta.

        private bool ValidarComboCuentaCompleto()
        {
            StringBuilder builder = new StringBuilder("");

            if (this.comboBoxNroCuenta.SelectedIndex < 0)
                builder.AppendLine("Nro Cuenta");

            if (builder.Length == 0)
                return true;
            else
            {
                MessageBox.Show("Los siguientes campos requieren un valor:\r\n" + builder.ToString(), "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool ValidarCampos()
        {
            return ValidarComboCuentaCompleto();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                FormFormularioModif formuModif = new FormFormularioModif();
                formuModif.Show();
                this.Close();
            }
        }

        private void FormModifTipoCta_Load(object sender, EventArgs e)
        {
            //modif
        }



    }
}
