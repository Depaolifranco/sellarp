namespace PagoElectronico.ABM_Cuenta
{
    partial class FormModifTipoCta
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
            this.comboBoxNroCuenta = new System.Windows.Forms.ComboBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNroCuenta
            // 
            this.labelNroCuenta.AutoSize = true;
            this.labelNroCuenta.Location = new System.Drawing.Point(12, 19);
            this.labelNroCuenta.Name = "labelNroCuenta";
            this.labelNroCuenta.Size = new System.Drawing.Size(108, 13);
            this.labelNroCuenta.TabIndex = 0;
            this.labelNroCuenta.Text = "Seleccione la Cuenta";
            this.labelNroCuenta.Click += new System.EventHandler(this.labelNroCuenta_Click);
            // 
            // comboBoxNroCuenta
            // 
            this.comboBoxNroCuenta.FormattingEnabled = true;
            this.comboBoxNroCuenta.Location = new System.Drawing.Point(126, 16);
            this.comboBoxNroCuenta.Name = "comboBoxNroCuenta";
            this.comboBoxNroCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNroCuenta.TabIndex = 7;
            this.comboBoxNroCuenta.Text = "Cuentas Propias";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(15, 106);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 8;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // FormModifTipoCta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 150);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.comboBoxNroCuenta);
            this.Controls.Add(this.labelNroCuenta);
            this.Name = "FormModifTipoCta";
            this.Text = "Modificacion de Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNroCuenta;
        private System.Windows.Forms.ComboBox comboBoxNroCuenta;
        private System.Windows.Forms.Button buttonModificar;
    }
}