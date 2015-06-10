namespace PagoElectronico.ABM_Cuenta
{
    partial class FormNoSeleccionoCta
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
            this.labelNoIngresoCta = new System.Windows.Forms.Label();
            this.labelSeleccionaCta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoIngresoCta
            // 
            this.labelNoIngresoCta.AutoSize = true;
            this.labelNoIngresoCta.Location = new System.Drawing.Point(40, 27);
            this.labelNoIngresoCta.Name = "labelNoIngresoCta";
            this.labelNoIngresoCta.Size = new System.Drawing.Size(124, 13);
            this.labelNoIngresoCta.TabIndex = 0;
            this.labelNoIngresoCta.Text = "Se ha producido un error";
            // 
            // labelSeleccionaCta
            // 
            this.labelSeleccionaCta.AutoSize = true;
            this.labelSeleccionaCta.Location = new System.Drawing.Point(28, 56);
            this.labelSeleccionaCta.Name = "labelSeleccionaCta";
            this.labelSeleccionaCta.Size = new System.Drawing.Size(152, 13);
            this.labelSeleccionaCta.TabIndex = 1;
            this.labelSeleccionaCta.Text = "Debe Seleccionar Una Cuenta";
            // 
            // FormNoSeleccionoCta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 118);
            this.Controls.Add(this.labelSeleccionaCta);
            this.Controls.Add(this.labelNoIngresoCta);
            this.Name = "FormNoSeleccionoCta";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoIngresoCta;
        private System.Windows.Forms.Label labelSeleccionaCta;
    }
}