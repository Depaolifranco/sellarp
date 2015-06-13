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

        private void buttonListados_Click(object sender, EventArgs e)
        {
            PagoElectronico.Listados.ListadoEstadistico listados = new PagoElectronico.Listados.ListadoEstadistico();
            listados.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoElectronico.ABM_Rol.FormABMRol pantallaRol = new PagoElectronico.ABM_Rol.FormABMRol();
            pantallaRol.Show();
            this.Hide();
        }

        private void buttonTransferencias_Click(object sender, EventArgs e)
        {
            PagoElectronico.Transferencias.PantallaTransferencias tranf = new PagoElectronico.Transferencias.PantallaTransferencias();
            tranf.Show();
            this.Hide();
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRetiros_Click(object sender, EventArgs e)
        {
            PagoElectronico.Retiros.PantallaRetiros retiros = new PagoElectronico.Retiros.PantallaRetiros();
            retiros.Show();
            this.Hide();
        }
    }
}
