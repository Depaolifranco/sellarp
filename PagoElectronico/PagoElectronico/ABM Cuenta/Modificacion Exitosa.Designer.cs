namespace PagoElectronico.ABM_Cuenta
{
    partial class FormModificExitosa
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
            this.labelModifExitosa = new System.Windows.Forms.Label();
            this.labelNuevoTipoCta = new System.Windows.Forms.Label();
            this.labelFechaVenc = new System.Windows.Forms.Label();
            this.textBoxNuevoTipoCta = new System.Windows.Forms.TextBox();
            this.textBoxFechaVenc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelModifExitosa
            // 
            this.labelModifExitosa.AutoSize = true;
            this.labelModifExitosa.Location = new System.Drawing.Point(39, 23);
            this.labelModifExitosa.Name = "labelModifExitosa";
            this.labelModifExitosa.Size = new System.Drawing.Size(205, 13);
            this.labelModifExitosa.TabIndex = 0;
            this.labelModifExitosa.Text = "La Modificacion se ha realizado con exito.";
            // 
            // labelNuevoTipoCta
            // 
            this.labelNuevoTipoCta.AutoSize = true;
            this.labelNuevoTipoCta.Location = new System.Drawing.Point(12, 61);
            this.labelNuevoTipoCta.Name = "labelNuevoTipoCta";
            this.labelNuevoTipoCta.Size = new System.Drawing.Size(115, 13);
            this.labelNuevoTipoCta.TabIndex = 1;
            this.labelNuevoTipoCta.Text = "Nuevo Tipo de Cuenta";
            // 
            // labelFechaVenc
            // 
            this.labelFechaVenc.AutoSize = true;
            this.labelFechaVenc.Location = new System.Drawing.Point(12, 95);
            this.labelFechaVenc.Name = "labelFechaVenc";
            this.labelFechaVenc.Size = new System.Drawing.Size(113, 13);
            this.labelFechaVenc.TabIndex = 2;
            this.labelFechaVenc.Text = "Fecha de Vencimiento";
            // 
            // textBoxNuevoTipoCta
            // 
            this.textBoxNuevoTipoCta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNuevoTipoCta.Enabled = false;
            this.textBoxNuevoTipoCta.Location = new System.Drawing.Point(133, 58);
            this.textBoxNuevoTipoCta.Name = "textBoxNuevoTipoCta";
            this.textBoxNuevoTipoCta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNuevoTipoCta.TabIndex = 3;
            // 
            // textBoxFechaVenc
            // 
            this.textBoxFechaVenc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFechaVenc.Enabled = false;
            this.textBoxFechaVenc.Location = new System.Drawing.Point(133, 92);
            this.textBoxFechaVenc.Name = "textBoxFechaVenc";
            this.textBoxFechaVenc.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaVenc.TabIndex = 4;
            // 
            // FormModificExitosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.textBoxFechaVenc);
            this.Controls.Add(this.textBoxNuevoTipoCta);
            this.Controls.Add(this.labelFechaVenc);
            this.Controls.Add(this.labelNuevoTipoCta);
            this.Controls.Add(this.labelModifExitosa);
            this.Name = "FormModificExitosa";
            this.Text = "Modificacion Realizada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModifExitosa;
        private System.Windows.Forms.Label labelNuevoTipoCta;
        private System.Windows.Forms.Label labelFechaVenc;
        private System.Windows.Forms.TextBox textBoxNuevoTipoCta;
        private System.Windows.Forms.TextBox textBoxFechaVenc;
    }
}