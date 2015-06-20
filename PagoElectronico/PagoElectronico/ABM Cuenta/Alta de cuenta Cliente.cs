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
    public partial class FormAltaCuenta : Form
    {
        public FormAltaCuenta()
        {
            InitializeComponent();
        }

//      Limpio el formulario

        private void label1_Click(object sender, EventArgs e)
        {
            this.textBox1Nro.Text = "";
            this.textBox2Pais.Text = "";
            this.textBoxEstado.Text = "";
            this.comboBox1Moneda.SelectedIndex = -1;
            this.textBoxFechaApe.Text = "";
            this.textBoxFechaVenc.Text = "";

        }

//      Valido que se hayan completado todos los campos

        private bool ValidarCamposCompletos()
        {
            StringBuilder builder = new StringBuilder("");

            if (this.textBox1Nro.Text.Equals(string.Empty))
                builder.AppendLine("Numero");
            if (this.textBox2Pais.Text.Equals(String.Empty))
                builder.AppendLine("Pais");
            if (this.comboBox1Moneda.SelectedIndex < 0)
                builder.AppendLine("Moneda");
            if (this.comboBoxTipoCta.SelectedIndex < 0)
                builder.AppendLine("Tipo de Cuenta");
            if (builder.Length == 0)
                return true;
            else
            {
                MessageBox.Show("Debe completar los siguientes campos antes de seguir:\r\n" + builder.ToString(), "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

//      Valido que solo se ingresen numeros al campo cuenta.


        private bool ValidarNroCuenta()
        {
            StringBuilder builder = new StringBuilder();

            int numericResult;
            if (!int.TryParse(this.textBox1Nro.Text, out numericResult))
                builder.AppendLine("Nro Cuenta");

            if (builder.Length == 0)
                return true;
            else
            {
                MessageBox.Show("El Numero de Cuenta es invalido.\r\n" + builder.ToString() + "\r\n Solo se permiten numeros.", "Valores no validos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

//      Agrupo las validaciones a realizar
        private bool RealizarValidaciones()
        {
            return (ValidarNroCuenta() && ValidarCamposCompletos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RealizarValidaciones())
            {
            }
        }

        private void FormAltaCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
