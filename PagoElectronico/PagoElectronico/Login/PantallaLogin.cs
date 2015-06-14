using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Login
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "admin")
            {
                if (textBoxPass.Text == "w23e")
                {
                    PagoElectronico.Funciones.PantallaFunciones funciones = new PagoElectronico.Funciones.PantallaFunciones();
                    funciones.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
