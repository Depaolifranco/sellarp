namespace PagoElectronico.Listados
{
    partial class ConsultaDeSaldoDeCuentas
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
            this.labelNroCuenta = new System.Windows.Forms.Label();
            this.textBoxNroCuenta = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.listBoxCuentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelNroCuenta
            // 
            this.labelNroCuenta.AutoSize = true;
            this.labelNroCuenta.Location = new System.Drawing.Point(12, 21);
            this.labelNroCuenta.Name = "labelNroCuenta";
            this.labelNroCuenta.Size = new System.Drawing.Size(64, 13);
            this.labelNroCuenta.TabIndex = 0;
            this.labelNroCuenta.Text = "Nro. Cuenta";
            // 
            // textBoxNroCuenta
            // 
            this.textBoxNroCuenta.Location = new System.Drawing.Point(82, 18);
            this.textBoxNroCuenta.Name = "textBoxNroCuenta";
            this.textBoxNroCuenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroCuenta.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(224, 16);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(324, 16);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // listBoxCuentas
            // 
            this.listBoxCuentas.FormattingEnabled = true;
            this.listBoxCuentas.Location = new System.Drawing.Point(15, 62);
            this.listBoxCuentas.Name = "listBoxCuentas";
            this.listBoxCuentas.Size = new System.Drawing.Size(384, 43);
            this.listBoxCuentas.TabIndex = 4;
            this.listBoxCuentas.SelectedIndexChanged += new System.EventHandler(this.listBoxCuentas_SelectedIndexChanged);
            // 
            // ConsultaDeSaldoDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 189);
            this.Controls.Add(this.listBoxCuentas);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNroCuenta);
            this.Controls.Add(this.labelNroCuenta);
            this.Name = "ConsultaDeSaldoDeCuentas";
            this.Text = "Consulta Saldo de Cuentas";
            this.Load += new System.EventHandler(this.ConsultaDeSaldoDeCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNroCuenta;
        private System.Windows.Forms.TextBox textBoxNroCuenta;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.ListBox listBoxCuentas;
    }
}