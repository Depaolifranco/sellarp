namespace PagoElectronico.ABM_Cuenta
{
    partial class FormAltaCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Nro = new System.Windows.Forms.TextBox();
            this.label2Nro = new System.Windows.Forms.Label();
            this.label3Pais = new System.Windows.Forms.Label();
            this.textBox2Pais = new System.Windows.Forms.TextBox();
            this.label4Moneda = new System.Windows.Forms.Label();
            this.comboBox1Moneda = new System.Windows.Forms.ComboBox();
            this.labelTipoCta = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxTipoCta = new System.Windows.Forms.ComboBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.labelFechaVencim = new System.Windows.Forms.Label();
            this.labelFechaCierre = new System.Windows.Forms.Label();
            this.labelFechaApertura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete el Formulario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1Nro
            // 
            this.textBox1Nro.Location = new System.Drawing.Point(111, 79);
            this.textBox1Nro.Name = "textBox1Nro";
            this.textBox1Nro.Size = new System.Drawing.Size(100, 20);
            this.textBox1Nro.TabIndex = 1;
            // 
            // label2Nro
            // 
            this.label2Nro.AutoSize = true;
            this.label2Nro.Location = new System.Drawing.Point(13, 82);
            this.label2Nro.Name = "label2Nro";
            this.label2Nro.Size = new System.Drawing.Size(92, 13);
            this.label2Nro.TabIndex = 2;
            this.label2Nro.Text = "Nro. de Cuenta (*)";
            // 
            // label3Pais
            // 
            this.label3Pais.AutoSize = true;
            this.label3Pais.Location = new System.Drawing.Point(12, 112);
            this.label3Pais.Name = "label3Pais";
            this.label3Pais.Size = new System.Drawing.Size(40, 13);
            this.label3Pais.TabIndex = 3;
            this.label3Pais.Text = "Pais (*)";
            // 
            // textBox2Pais
            // 
            this.textBox2Pais.Location = new System.Drawing.Point(110, 109);
            this.textBox2Pais.Name = "textBox2Pais";
            this.textBox2Pais.Size = new System.Drawing.Size(100, 20);
            this.textBox2Pais.TabIndex = 4;
            this.textBox2Pais.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4Moneda
            // 
            this.label4Moneda.AutoSize = true;
            this.label4Moneda.Location = new System.Drawing.Point(12, 140);
            this.label4Moneda.Name = "label4Moneda";
            this.label4Moneda.Size = new System.Drawing.Size(59, 13);
            this.label4Moneda.TabIndex = 5;
            this.label4Moneda.Text = "Moneda (*)";
            // 
            // comboBox1Moneda
            // 
            this.comboBox1Moneda.FormattingEnabled = true;
            this.comboBox1Moneda.Items.AddRange(new object[] {
            "Dolares"});
            this.comboBox1Moneda.Location = new System.Drawing.Point(110, 137);
            this.comboBox1Moneda.Name = "comboBox1Moneda";
            this.comboBox1Moneda.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Moneda.TabIndex = 6;
            this.comboBox1Moneda.Text = "Seleccione una Moneda";
            // 
            // labelTipoCta
            // 
            this.labelTipoCta.AutoSize = true;
            this.labelTipoCta.Location = new System.Drawing.Point(12, 167);
            this.labelTipoCta.Name = "labelTipoCta";
            this.labelTipoCta.Size = new System.Drawing.Size(93, 13);
            this.labelTipoCta.TabIndex = 7;
            this.labelTipoCta.Text = "Tipo de Cuenta (*)";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(12, 196);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 8;
            this.labelEstado.Text = "Estado";
            this.labelEstado.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxTipoCta
            // 
            this.comboBoxTipoCta.FormattingEnabled = true;
            this.comboBoxTipoCta.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBoxTipoCta.Location = new System.Drawing.Point(110, 164);
            this.comboBoxTipoCta.Name = "comboBoxTipoCta";
            this.comboBoxTipoCta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoCta.TabIndex = 9;
            this.comboBoxTipoCta.Text = "Seleccione un Tipo de Cuenta";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(110, 193);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstado.TabIndex = 10;
            // 
            // labelFechaVencim
            // 
            this.labelFechaVencim.AutoSize = true;
            this.labelFechaVencim.Location = new System.Drawing.Point(253, 112);
            this.labelFechaVencim.Name = "labelFechaVencim";
            this.labelFechaVencim.Size = new System.Drawing.Size(113, 13);
            this.labelFechaVencim.TabIndex = 11;
            this.labelFechaVencim.Text = "Fecha de Vencimiento";
            // 
            // labelFechaCierre
            // 
            this.labelFechaCierre.AutoSize = true;
            this.labelFechaCierre.Location = new System.Drawing.Point(253, 140);
            this.labelFechaCierre.Name = "labelFechaCierre";
            this.labelFechaCierre.Size = new System.Drawing.Size(82, 13);
            this.labelFechaCierre.TabIndex = 12;
            this.labelFechaCierre.Text = "Fecha de Cierre";
            // 
            // labelFechaApertura
            // 
            this.labelFechaApertura.AutoSize = true;
            this.labelFechaApertura.Location = new System.Drawing.Point(257, 82);
            this.labelFechaApertura.Name = "labelFechaApertura";
            this.labelFechaApertura.Size = new System.Drawing.Size(95, 13);
            this.labelFechaApertura.TabIndex = 13;
            this.labelFechaApertura.Text = "Fecha de Apertura";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(379, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(379, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(379, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(110, 225);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 17;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(260, 225);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(15, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(98, 23);
            this.buttonBuscar.TabIndex = 21;
            this.buttonBuscar.Text = "Buscar Usuario";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // FormAltaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 282);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFechaApertura);
            this.Controls.Add(this.labelFechaCierre);
            this.Controls.Add(this.labelFechaVencim);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.comboBoxTipoCta);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelTipoCta);
            this.Controls.Add(this.comboBox1Moneda);
            this.Controls.Add(this.label4Moneda);
            this.Controls.Add(this.textBox2Pais);
            this.Controls.Add(this.label3Pais);
            this.Controls.Add(this.label2Nro);
            this.Controls.Add(this.textBox1Nro);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaCuenta";
            this.Text = "Formulario de Alta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Nro;
        private System.Windows.Forms.Label label2Nro;
        private System.Windows.Forms.Label label3Pais;
        private System.Windows.Forms.TextBox textBox2Pais;
        private System.Windows.Forms.Label label4Moneda;
        private System.Windows.Forms.ComboBox comboBox1Moneda;
        private System.Windows.Forms.Label labelTipoCta;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxTipoCta;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label labelFechaVencim;
        private System.Windows.Forms.Label labelFechaCierre;
        private System.Windows.Forms.Label labelFechaApertura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBuscar;
    }
}