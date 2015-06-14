namespace PagoElectronico.Depositos
{
    partial class PantallaDepositos
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
            this.labelCuenta = new System.Windows.Forms.Label();
            this.labelImporte = new System.Windows.Forms.Label();
            this.labelTipoMoneda = new System.Windows.Forms.Label();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxCuenta = new System.Windows.Forms.TextBox();
            this.buttonSelectCuenta = new System.Windows.Forms.Button();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.comboBoxTipoMoneda = new System.Windows.Forms.ComboBox();
            this.comboBoxTarjetas = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Location = new System.Drawing.Point(49, 36);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(44, 13);
            this.labelCuenta.TabIndex = 0;
            this.labelCuenta.Text = "Cuenta:";
            this.labelCuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(49, 78);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(45, 13);
            this.labelImporte.TabIndex = 1;
            this.labelImporte.Text = "Importe:";
            // 
            // labelTipoMoneda
            // 
            this.labelTipoMoneda.AutoSize = true;
            this.labelTipoMoneda.Location = new System.Drawing.Point(201, 79);
            this.labelTipoMoneda.Name = "labelTipoMoneda";
            this.labelTipoMoneda.Size = new System.Drawing.Size(73, 13);
            this.labelTipoMoneda.TabIndex = 2;
            this.labelTipoMoneda.Text = "Tipo Moneda:";
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.Location = new System.Drawing.Point(49, 123);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(93, 13);
            this.labelTarjeta.TabIndex = 3;
            this.labelTarjeta.Text = "Tarjeta de credito:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(49, 170);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxCuenta
            // 
            this.textBoxCuenta.Location = new System.Drawing.Point(95, 32);
            this.textBoxCuenta.Name = "textBoxCuenta";
            this.textBoxCuenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuenta.TabIndex = 5;
            // 
            // buttonSelectCuenta
            // 
            this.buttonSelectCuenta.Location = new System.Drawing.Point(202, 30);
            this.buttonSelectCuenta.Name = "buttonSelectCuenta";
            this.buttonSelectCuenta.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectCuenta.TabIndex = 6;
            this.buttonSelectCuenta.Text = "Seleccionar";
            this.buttonSelectCuenta.UseVisualStyleBackColor = true;
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(95, 75);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(100, 20);
            this.textBoxImporte.TabIndex = 7;
            this.textBoxImporte.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBoxTipoMoneda
            // 
            this.comboBoxTipoMoneda.FormattingEnabled = true;
            this.comboBoxTipoMoneda.Location = new System.Drawing.Point(277, 75);
            this.comboBoxTipoMoneda.Name = "comboBoxTipoMoneda";
            this.comboBoxTipoMoneda.Size = new System.Drawing.Size(76, 21);
            this.comboBoxTipoMoneda.TabIndex = 8;
            // 
            // comboBoxTarjetas
            // 
            this.comboBoxTarjetas.FormattingEnabled = true;
            this.comboBoxTarjetas.Location = new System.Drawing.Point(156, 120);
            this.comboBoxTarjetas.Name = "comboBoxTarjetas";
            this.comboBoxTarjetas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTarjetas.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(95, 225);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(225, 225);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(95, 167);
            this.maskedTextBoxFecha.Mask = "00/00/0000";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.ReadOnly = true;
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFecha.TabIndex = 13;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // PantallaDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 298);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxTarjetas);
            this.Controls.Add(this.comboBoxTipoMoneda);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.buttonSelectCuenta);
            this.Controls.Add(this.textBoxCuenta);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTarjeta);
            this.Controls.Add(this.labelTipoMoneda);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.labelCuenta);
            this.Name = "PantallaDepositos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositos";
            this.Load += new System.EventHandler(this.PantallaDepositos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Label labelTipoMoneda;
        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxCuenta;
        private System.Windows.Forms.Button buttonSelectCuenta;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.ComboBox comboBoxTipoMoneda;
        private System.Windows.Forms.ComboBox comboBoxTarjetas;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
    }
}