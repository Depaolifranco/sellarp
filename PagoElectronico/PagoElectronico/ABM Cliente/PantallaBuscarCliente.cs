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
    public partial class PantallaBuscarClientes : Form
    {
        public PantallaBuscarClientes()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxMail.Text = "";
            textBoxDoc.Text = "";
        }

        private void PantallaListados_Load(object sender, EventArgs e)
        {

        }
    }
}
