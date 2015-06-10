namespace PagoElectronico.ABM_Cuenta
{
    partial class FormFormularioModif
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
            this.labelNvoTipoCta = new System.Windows.Forms.Label();
            this.comboBoxTipoCtaModif = new System.Windows.Forms.ComboBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelTipoCtaActual = new System.Windows.Forms.Label();
            this.textBoxTipoCtaActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNvoTipoCta
            // 
            this.labelNvoTipoCta.AutoSize = true;
            this.labelNvoTipoCta.Location = new System.Drawing.Point(12, 64);
            this.labelNvoTipoCta.Name = "labelNvoTipoCta";
            this.labelNvoTipoCta.Size = new System.Drawing.Size(115, 13);
            this.labelNvoTipoCta.TabIndex = 0;
            this.labelNvoTipoCta.Text = "Nuevo Tipo de Cuenta";
            // 
            // comboBoxTipoCtaModif
            // 
            this.comboBoxTipoCtaModif.AutoCompleteCustomSource.AddRange(new string[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBoxTipoCtaModif.FormattingEnabled = true;
            this.comboBoxTipoCtaModif.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBoxTipoCtaModif.Location = new System.Drawing.Point(144, 61);
            this.comboBoxTipoCtaModif.Name = "comboBoxTipoCtaModif";
            this.comboBoxTipoCtaModif.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoCtaModif.TabIndex = 1;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(32, 124);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 2;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(144, 124);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // labelTipoCtaActual
            // 
            this.labelTipoCtaActual.AutoSize = true;
            this.labelTipoCtaActual.Location = new System.Drawing.Point(12, 29);
            this.labelTipoCtaActual.Name = "labelTipoCtaActual";
            this.labelTipoCtaActual.Size = new System.Drawing.Size(113, 13);
            this.labelTipoCtaActual.TabIndex = 4;
            this.labelTipoCtaActual.Text = "Tipo de Cuenta Actual";
            // 
            // textBoxTipoCtaActual
            // 
            this.textBoxTipoCtaActual.Location = new System.Drawing.Point(144, 26);
            this.textBoxTipoCtaActual.Name = "textBoxTipoCtaActual";
            this.textBoxTipoCtaActual.Size = new System.Drawing.Size(121, 20);
            this.textBoxTipoCtaActual.TabIndex = 5;
            this.textBoxTipoCtaActual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormFormularioModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.textBoxTipoCtaActual);
            this.Controls.Add(this.labelTipoCtaActual);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.comboBoxTipoCtaModif);
            this.Controls.Add(this.labelNvoTipoCta);
            this.Name = "FormFormularioModif";
            this.Text = "Formulario de Modificacion de Cuenta";
            this.Load += new System.EventHandler(this.FormFormularioModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNvoTipoCta;
        private System.Windows.Forms.ComboBox comboBoxTipoCtaModif;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelTipoCtaActual;
        private System.Windows.Forms.TextBox textBoxTipoCtaActual;
    }
}