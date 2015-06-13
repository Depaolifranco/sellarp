namespace PagoElectronico.Transferencias
{
    partial class PantallaTransferencias
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
            this.labelCuentaOrigen = new System.Windows.Forms.Label();
            this.labelCuentaDestino = new System.Windows.Forms.Label();
            this.comboBoxCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscarCuenta = new System.Windows.Forms.Button();
            this.labelImporte = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCuentaOrigen
            // 
            this.labelCuentaOrigen.AutoSize = true;
            this.labelCuentaOrigen.Location = new System.Drawing.Point(40, 39);
            this.labelCuentaOrigen.Name = "labelCuentaOrigen";
            this.labelCuentaOrigen.Size = new System.Drawing.Size(76, 13);
            this.labelCuentaOrigen.TabIndex = 0;
            this.labelCuentaOrigen.Text = "Cuenta origen:";
            // 
            // labelCuentaDestino
            // 
            this.labelCuentaDestino.AutoSize = true;
            this.labelCuentaDestino.Location = new System.Drawing.Point(40, 76);
            this.labelCuentaDestino.Name = "labelCuentaDestino";
            this.labelCuentaDestino.Size = new System.Drawing.Size(81, 13);
            this.labelCuentaDestino.TabIndex = 1;
            this.labelCuentaDestino.Text = "Cuenta destino:";
            // 
            // comboBoxCuentaOrigen
            // 
            this.comboBoxCuentaOrigen.FormattingEnabled = true;
            this.comboBoxCuentaOrigen.Location = new System.Drawing.Point(147, 36);
            this.comboBoxCuentaOrigen.Name = "comboBoxCuentaOrigen";
            this.comboBoxCuentaOrigen.Size = new System.Drawing.Size(164, 21);
            this.comboBoxCuentaOrigen.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBuscarCuenta
            // 
            this.buttonBuscarCuenta.Location = new System.Drawing.Point(335, 71);
            this.buttonBuscarCuenta.Name = "buttonBuscarCuenta";
            this.buttonBuscarCuenta.Size = new System.Drawing.Size(113, 23);
            this.buttonBuscarCuenta.TabIndex = 4;
            this.buttonBuscarCuenta.Text = "Buscar cuenta";
            this.buttonBuscarCuenta.UseVisualStyleBackColor = true;
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(40, 129);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(45, 13);
            this.labelImporte.TabIndex = 5;
            this.labelImporte.Text = "Importe:";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(147, 126);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(100, 20);
            this.textBoxImporte.TabIndex = 6;
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Items.AddRange(new object[] {
            "U$S"});
            this.comboBoxMoneda.Location = new System.Drawing.Point(253, 126);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(58, 21);
            this.comboBoxMoneda.TabIndex = 7;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(147, 198);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(236, 198);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 9;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // PantallaTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 266);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.buttonBuscarCuenta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxCuentaOrigen);
            this.Controls.Add(this.labelCuentaDestino);
            this.Controls.Add(this.labelCuentaOrigen);
            this.Name = "PantallaTransferencias";
            this.Text = "Transferencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCuentaOrigen;
        private System.Windows.Forms.Label labelCuentaDestino;
        private System.Windows.Forms.ComboBox comboBoxCuentaOrigen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscarCuenta;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonFinalizar;
    }
}