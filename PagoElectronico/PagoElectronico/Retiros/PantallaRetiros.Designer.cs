namespace PagoElectronico.Retiros
{
    partial class PantallaRetiros
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
            this.comboBoxCuenta = new System.Windows.Forms.ComboBox();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.textBoxNumeroDoc = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.labelNumeroDoc = new System.Windows.Forms.Label();
            this.labelImporte = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.labelBanco = new System.Windows.Forms.Label();
            this.comboBoxBanco = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCuenta
            // 
            this.comboBoxCuenta.FormattingEnabled = true;
            this.comboBoxCuenta.Location = new System.Drawing.Point(81, 35);
            this.comboBoxCuenta.Name = "comboBoxCuenta";
            this.comboBoxCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCuenta.TabIndex = 0;
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Location = new System.Drawing.Point(31, 38);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(44, 13);
            this.labelCuenta.TabIndex = 1;
            this.labelCuenta.Text = "Cuenta:";
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.Location = new System.Drawing.Point(31, 85);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.labelTipoDoc.TabIndex = 2;
            this.labelTipoDoc.Text = "Tipo Documento:";
            // 
            // textBoxNumeroDoc
            // 
            this.textBoxNumeroDoc.Location = new System.Drawing.Point(270, 82);
            this.textBoxNumeroDoc.Name = "textBoxNumeroDoc";
            this.textBoxNumeroDoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDoc.TabIndex = 3;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(141, 82);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(61, 21);
            this.comboBoxTipoDoc.TabIndex = 4;
            // 
            // labelNumeroDoc
            // 
            this.labelNumeroDoc.AutoSize = true;
            this.labelNumeroDoc.Location = new System.Drawing.Point(217, 85);
            this.labelNumeroDoc.Name = "labelNumeroDoc";
            this.labelNumeroDoc.Size = new System.Drawing.Size(47, 13);
            this.labelNumeroDoc.TabIndex = 5;
            this.labelNumeroDoc.Text = "Numero:";
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(31, 127);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(45, 13);
            this.labelImporte.TabIndex = 6;
            this.labelImporte.Text = "Importe:";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(102, 124);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(100, 20);
            this.textBoxImporte.TabIndex = 7;
            // 
            // labelBanco
            // 
            this.labelBanco.AutoSize = true;
            this.labelBanco.Location = new System.Drawing.Point(31, 174);
            this.labelBanco.Name = "labelBanco";
            this.labelBanco.Size = new System.Drawing.Size(41, 13);
            this.labelBanco.TabIndex = 8;
            this.labelBanco.Text = "Banco:";
            // 
            // comboBoxBanco
            // 
            this.comboBoxBanco.FormattingEnabled = true;
            this.comboBoxBanco.Items.AddRange(new object[] {
            "Ciudad",
            "Nacion"});
            this.comboBoxBanco.Location = new System.Drawing.Point(81, 171);
            this.comboBoxBanco.Name = "comboBoxBanco";
            this.comboBoxBanco.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBanco.TabIndex = 9;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(31, 220);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(102, 217);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.textBoxFecha.TabIndex = 11;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(230, 281);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 12;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(81, 281);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // PantallaRetiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 349);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.comboBoxBanco);
            this.Controls.Add(this.labelBanco);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.labelNumeroDoc);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.textBoxNumeroDoc);
            this.Controls.Add(this.labelTipoDoc);
            this.Controls.Add(this.labelCuenta);
            this.Controls.Add(this.comboBoxCuenta);
            this.Name = "PantallaRetiros";
            this.Text = "Retiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCuenta;
        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.TextBox textBoxNumeroDoc;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.Label labelNumeroDoc;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label labelBanco;
        private System.Windows.Forms.ComboBox comboBoxBanco;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}