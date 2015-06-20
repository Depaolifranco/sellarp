namespace PagoElectronico.ABM_Cuenta
{
    partial class Admin_Modif_Tipo_de_Cuentas
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
            this.comboBoxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.labelTipoDeCuenta = new System.Windows.Forms.Label();
            this.labelNuevoCosto = new System.Windows.Forms.Label();
            this.textBoxNuevoCosto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxTipoCuenta
            // 
            this.comboBoxTipoCuenta.FormattingEnabled = true;
            this.comboBoxTipoCuenta.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce"});
            this.comboBoxTipoCuenta.Location = new System.Drawing.Point(118, 28);
            this.comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            this.comboBoxTipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoCuenta.TabIndex = 0;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(118, 184);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // labelTipoDeCuenta
            // 
            this.labelTipoDeCuenta.AutoSize = true;
            this.labelTipoDeCuenta.Location = new System.Drawing.Point(12, 31);
            this.labelTipoDeCuenta.Name = "labelTipoDeCuenta";
            this.labelTipoDeCuenta.Size = new System.Drawing.Size(80, 13);
            this.labelTipoDeCuenta.TabIndex = 2;
            this.labelTipoDeCuenta.Text = "Tipo de Cuenta";
            // 
            // labelNuevoCosto
            // 
            this.labelNuevoCosto.AutoSize = true;
            this.labelNuevoCosto.Location = new System.Drawing.Point(12, 90);
            this.labelNuevoCosto.Name = "labelNuevoCosto";
            this.labelNuevoCosto.Size = new System.Drawing.Size(69, 13);
            this.labelNuevoCosto.TabIndex = 3;
            this.labelNuevoCosto.Text = "Nuevo Costo";
            // 
            // textBoxNuevoCosto
            // 
            this.textBoxNuevoCosto.Location = new System.Drawing.Point(118, 87);
            this.textBoxNuevoCosto.Name = "textBoxNuevoCosto";
            this.textBoxNuevoCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNuevoCosto.TabIndex = 4;
            // 
            // Admin_Modif_Tipo_de_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 231);
            this.Controls.Add(this.textBoxNuevoCosto);
            this.Controls.Add(this.labelNuevoCosto);
            this.Controls.Add(this.labelTipoDeCuenta);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.comboBoxTipoCuenta);
            this.Name = "Admin_Modif_Tipo_de_Cuentas";
            this.Text = "Modificar Costos de los Tipos de Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoCuenta;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelTipoDeCuenta;
        private System.Windows.Forms.Label labelNuevoCosto;
        private System.Windows.Forms.TextBox textBoxNuevoCosto;
    }
}