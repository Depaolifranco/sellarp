using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Rol
{
    public partial class FormABMRol : Form
    {
        public FormABMRol()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaNuevoRol pantallaRol = new PantallaNuevoRol();
            pantallaRol.MdiParent = this;
            pantallaRol.Show();
        }
    }
}
