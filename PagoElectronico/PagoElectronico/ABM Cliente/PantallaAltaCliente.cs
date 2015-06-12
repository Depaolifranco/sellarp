using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class PantallaAltaCliente : Form
    {
        public PantallaAltaCliente()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPass.Text = "";
            //comboBoxRol.ResetText;
            textBoxPregunta.Text = "";
            textBoxRespuesta.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            //comboBoxTipoDoc.ResetText;
            textBoxNumeroDoc.Text = "";
            textBoxMail.Text = "";
            textBoxPais.Text = "";
            textBoxCalle.Text = "";
            textBoxPiso.Text = "";
            textBoxDepto.Text = "";
            textBoxLocalidad.Text = "";
            textBoxNacionalidad.Text = "";
        }
    }
}
