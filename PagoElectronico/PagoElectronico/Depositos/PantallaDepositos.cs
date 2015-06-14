using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Depositos
{
    public partial class PantallaDepositos : Form
    {
        public PantallaDepositos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaDepositos_Load(object sender, EventArgs e)
        {
            maskedTextBoxFecha.Text = DateTime.Now.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            PagoElectronico.Funciones.PantallaFunciones funciones = new PagoElectronico.Funciones.PantallaFunciones();
            funciones.Show();
            this.Close();
        }
    }
}
