using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Facturacion
{
    public partial class Facturaciones : Form
    {
        public Facturaciones()
        {
            InitializeComponent();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar factura = new Facturar();
            factura.MdiParent = this;
            factura.Show();
        }

        private void modificarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarFactura facturaModificable = new ModificarFactura();
            facturaModificable.MdiParent = this;
            facturaModificable.Show();
        }

        private void Facturaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
