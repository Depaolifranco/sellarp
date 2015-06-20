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
    public partial class PantallaABMCliente : Form
    {
        public PantallaABMCliente()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaAltaCliente pantallaCrear = new PantallaAltaCliente();
            pantallaCrear.MdiParent = this;
            pantallaCrear.Show();
           
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaBuscarClientes buscar = new PantallaBuscarClientes();
            buscar.MdiParent = this;
            buscar.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoElectronico.Funciones.PantallaFunciones funciones = new PagoElectronico.Funciones.PantallaFunciones();
            funciones.Show();
            this.Close();
        }

        private void PantallaABMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
