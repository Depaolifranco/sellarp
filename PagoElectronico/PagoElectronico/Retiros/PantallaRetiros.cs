using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Retiros
{
    public partial class PantallaRetiros : Form
    {
        public PantallaRetiros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PagoElectronico.Funciones.PantallaFunciones funciones = new PagoElectronico.Funciones.PantallaFunciones();
            funciones.Show();
        }
    }
}
