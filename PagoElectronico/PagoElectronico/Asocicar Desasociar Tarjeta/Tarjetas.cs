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
    public partial class Tarjetas : Form
    {
        public Tarjetas()
        {
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_de_Tarjeta formularioBusqueda = new Busqueda_de_Tarjeta();
            formularioBusqueda.MdiParent = this;
            formularioBusqueda.Show();
        }

        private void asociarTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_De_Alta formularioAlta = new Formulario_De_Alta();
            formularioAlta.MdiParent = this;
            formularioAlta.Show();
        }
    }
}
