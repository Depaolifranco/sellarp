﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            PagoElectronico.Login.PantallaLogin login = new PagoElectronico.Login.PantallaLogin();
            login.Show();
            this.Hide();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {

        }
    }
}
