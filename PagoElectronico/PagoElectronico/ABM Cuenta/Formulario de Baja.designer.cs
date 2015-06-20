namespace PagoElectronico.ABM_Cuenta
{
    partial class Listado_Seleccion_Baja
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
            this.labelSeleccioneCuenta = new System.Windows.Forms.Label();
            this.comboSeleccioneCtaBaja = new System.Windows.Forms.ComboBox();
            this.buttonCerrarCta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeleccioneCuenta
            // 
            this.labelSeleccioneCuenta.AutoSize = true;
            this.labelSeleccioneCuenta.Location = new System.Drawing.Point(12, 37);
            this.labelSeleccioneCuenta.Name = "labelSeleccioneCuenta";
            this.labelSeleccioneCuenta.Size = new System.Drawing.Size(146, 13);
            this.labelSeleccioneCuenta.TabIndex = 0;
            this.labelSeleccioneCuenta.Text = "Seleccione la cuenta a cerrar";
            // 
            // comboSeleccioneCtaBaja
            // 
            this.comboSeleccioneCtaBaja.FormattingEnabled = true;
            this.comboSeleccioneCtaBaja.Location = new System.Drawing.Point(178, 34);
            this.comboSeleccioneCtaBaja.Name = "comboSeleccioneCtaBaja";
            this.comboSeleccioneCtaBaja.Size = new System.Drawing.Size(121, 21);
            this.comboSeleccioneCtaBaja.TabIndex = 1;
            // 
            // buttonCerrarCta
            // 
            this.buttonCerrarCta.Location = new System.Drawing.Point(15, 85);
            this.buttonCerrarCta.Name = "buttonCerrarCta";
            this.buttonCerrarCta.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrarCta.TabIndex = 2;
            this.buttonCerrarCta.Text = "Cerrar";
            this.buttonCerrarCta.UseVisualStyleBackColor = true;
            this.buttonCerrarCta.Click += new System.EventHandler(this.buttonCerrarCta_Click);
            // 
            // Listado_Seleccion_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 147);
            this.Controls.Add(this.buttonCerrarCta);
            this.Controls.Add(this.comboSeleccioneCtaBaja);
            this.Controls.Add(this.labelSeleccioneCuenta);
            this.Name = "Listado_Seleccion_Baja";
            this.Text = "Formulario de Bajas";
            this.Load += new System.EventHandler(this.Listado_Seleccion_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccioneCuenta;
        private System.Windows.Forms.ComboBox comboSeleccioneCtaBaja;
        private System.Windows.Forms.Button buttonCerrarCta;
    }
}