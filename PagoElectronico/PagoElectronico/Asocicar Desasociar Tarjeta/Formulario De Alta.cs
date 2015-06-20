using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Asociar_Desasociar_Tarjeta
{
    public partial class Formulario_De_Alta : Form
    {
        public Formulario_De_Alta()
        {
            InitializeComponent();
        }


        private void Formulario_De_Alta_Load(object sender, EventArgs e)
        {

        }


//      Limpio los valores del Formulario

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNroTarjeta.Text = "";
            this.comboBoxEmisor.SelectedIndex = -1;
            this.textBoxFechaEmision.Text = "";
            this.textBoxFechaVenci.Text = "";
            this.textBoxCodigoSeguridad.Text = "";
        }

//      Valido que los campos no esten vacios

        private bool ChequearCamposNoVacios()
        {
            StringBuilder formuAlta = new StringBuilder("");

            if (this.textBoxNroTarjeta.Text.Equals(String.Empty))
                formuAlta.AppendLine("Nro. Tarjeta");
            if (this.textBoxFechaEmision.Text.Equals(String.Empty))
                formuAlta.AppendLine("Fecha Emision");
            if (this.textBoxFechaVenci.Text.Equals(String.Empty))
                formuAlta.AppendLine("Fecha Vencimiento");
            if (this.comboBoxEmisor.SelectedIndex < 0)
                formuAlta.AppendLine("Emisor");
            if (this.textBoxCodigoSeguridad.Text.Equals(String.Empty))
                formuAlta.AppendLine("Codigo Seguridad");

            if (formuAlta.Length == 0)
                return true;
            else
            {
                MessageBox.Show("Los siguientes campos estan vacios:\r\n" + formuAlta.ToString(), "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

//      Valido los valores de los campos

        private bool ChequearValoresCampos()
        {
            StringBuilder formularioAlta = new StringBuilder();

            int resultado;
            DateTime fecha;
            if (!int.TryParse(this.textBoxNroTarjeta.Text, out resultado))
                formularioAlta.AppendLine("Nro Tarjeta");
            if (!int.TryParse(this.textBoxCodigoSeguridad.Text, out resultado))
                formularioAlta.AppendLine("Codigo de Seguridad");
            if (!DateTime.TryParse(this.textBoxFechaEmision.Text, out fecha))
                formularioAlta.AppendLine("Fecha de Emision");
            if (!DateTime.TryParse(this.textBoxFechaVenci.Text, out fecha))
                formularioAlta.AppendLine("Fecha de Vencimiento");

            if (formularioAlta.Length == 0)
                return true;
            else
            {
                MessageBox.Show("Los siguientes campos presentan valores invalidos.\r\n" + formularioAlta.ToString() + "\r\n Solo se permiten numeros.", "Valores no validos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

//      Agrupo las validaciones

        private bool RealizarValidaciones()
        {
            return (ChequearValoresCampos() && ChequearCamposNoVacios());
        }

        private void buttonAsociar_Click(object sender, EventArgs e)
        {
            if (RealizarValidaciones())
            {
            }
        }

        private void textBoxNroTarjeta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
