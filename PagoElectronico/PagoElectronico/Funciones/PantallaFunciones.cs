using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Funciones
{
    public partial class PantallaFunciones : Form
    {
        public PantallaFunciones()
        {
            InitializeComponent();
        }

        private void buttonABMCliente_Click(object sender, EventArgs e)
        {
            PagoElectronico.ABM_Cliente.PantallaABMCliente cliente = new PagoElectronico.ABM_Cliente.PantallaABMCliente();
            cliente.Show();
            this.Hide();
        }
    }
}
