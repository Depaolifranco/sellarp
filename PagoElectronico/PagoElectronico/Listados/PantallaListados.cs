using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Listados
{
    public partial class PantallaListados : Form
    {
        public PantallaListados()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxMail.Text = "";
            textBoxDoc.Text = "";
        }
    }
}
