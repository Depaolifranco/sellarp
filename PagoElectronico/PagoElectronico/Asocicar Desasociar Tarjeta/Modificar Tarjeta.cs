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
    public partial class Modificar_Tarjeta : Form
    {
        public Modificar_Tarjeta()
        {
            InitializeComponent();
        }

        private void buttonDesasociar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realmente desea desasociar la tarjeta?");
        }
    }
}
