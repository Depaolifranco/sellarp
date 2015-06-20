using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class FormMainABMCuenta : Form
    {
        public FormMainABMCuenta()
        {
            InitializeComponent();
        }

//      Acceso a las funcionalidades del ABM

        private void nuevaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Cuenta.FormAltaCuenta pantallaCrear = new ABM_Cuenta.FormAltaCuenta();
            pantallaCrear.MdiParent = this;
            pantallaCrear.Show();
        }

        private void modificarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Cuenta.FormModifTipoCta pantallaModif = new FormModifTipoCta();
            pantallaModif.MdiParent = this;
            pantallaModif.Show();
        }

        private void cerrarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Seleccion_Baja pantallaCerrar = new Listado_Seleccion_Baja();
            pantallaCerrar.MdiParent = this;
            pantallaCerrar.Show();
        }

        private void FormMainABMCuenta_Load(object sender, EventArgs e)
        {

        }



    }
}
