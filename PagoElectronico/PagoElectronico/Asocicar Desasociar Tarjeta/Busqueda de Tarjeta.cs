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
    public partial class Busqueda_de_Tarjeta : Form
    {
        public Busqueda_de_Tarjeta()
        {
            InitializeComponent();

            CargarTarjetas();
        }

        private void CargarTarjetas()
        {
            // Asi se carga un ComboBox
           // cboTipo.DataSource = TipoDocumentoDataAccess.Listar();
           // cboTipo.ValueMember = "Tipo_Documento_Codigo";
           // cboTipo.DisplayMember = "Tipo_Documento";

        }

        private void Busqueda_de_Tarjeta_Load(object sender, EventArgs e)
        {

        }

        private void buttonFormularioModif_Click(object sender, EventArgs e)
        {
            Modificar_Tarjeta formuModificacion = new Modificar_Tarjeta();
            this.Close();
            formuModificacion.Show();
        }

        private void buttonDesasociar_Click(object sender, EventArgs e)
        {
            //Impactar la Base Desasociando la Tarjeta
        }


    }
}
