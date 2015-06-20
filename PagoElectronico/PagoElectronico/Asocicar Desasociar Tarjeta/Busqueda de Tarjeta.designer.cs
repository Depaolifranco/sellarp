namespace PagoElectronico.Asociar_Desasociar_Tarjeta
{
    partial class Busqueda_de_Tarjeta
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
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonFormularioModif = new System.Windows.Forms.Button();
            this.labelSeleccioneTarj = new System.Windows.Forms.Label();
            this.buttonDesasociar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.Location = new System.Drawing.Point(21, 42);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(40, 13);
            this.labelTarjeta.TabIndex = 0;
            this.labelTarjeta.Text = "Tarjeta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonFormularioModif
            // 
            this.buttonFormularioModif.Location = new System.Drawing.Point(24, 104);
            this.buttonFormularioModif.Name = "buttonFormularioModif";
            this.buttonFormularioModif.Size = new System.Drawing.Size(80, 23);
            this.buttonFormularioModif.TabIndex = 2;
            this.buttonFormularioModif.Text = "Modificar";
            this.buttonFormularioModif.UseVisualStyleBackColor = true;
            this.buttonFormularioModif.Click += new System.EventHandler(this.buttonFormularioModif_Click);
            // 
            // labelSeleccioneTarj
            // 
            this.labelSeleccioneTarj.AutoSize = true;
            this.labelSeleccioneTarj.Location = new System.Drawing.Point(21, 9);
            this.labelSeleccioneTarj.Name = "labelSeleccioneTarj";
            this.labelSeleccioneTarj.Size = new System.Drawing.Size(213, 13);
            this.labelSeleccioneTarj.TabIndex = 3;
            this.labelSeleccioneTarj.Text = "Seleccione la tarjeta a modificar/desasociar";
            // 
            // buttonDesasociar
            // 
            this.buttonDesasociar.Location = new System.Drawing.Point(168, 104);
            this.buttonDesasociar.Name = "buttonDesasociar";
            this.buttonDesasociar.Size = new System.Drawing.Size(75, 23);
            this.buttonDesasociar.TabIndex = 4;
            this.buttonDesasociar.Text = "Desasociar";
            this.buttonDesasociar.UseVisualStyleBackColor = true;
            this.buttonDesasociar.Click += new System.EventHandler(this.buttonDesasociar_Click);
            // 
            // Busqueda_de_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.buttonDesasociar);
            this.Controls.Add(this.labelSeleccioneTarj);
            this.Controls.Add(this.buttonFormularioModif);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTarjeta);
            this.Name = "Busqueda_de_Tarjeta";
            this.Text = "Buscar Tarjeta a Modificar/Dsasociar";
            this.Load += new System.EventHandler(this.Busqueda_de_Tarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonFormularioModif;
        private System.Windows.Forms.Label labelSeleccioneTarj;
        private System.Windows.Forms.Button buttonDesasociar;
    }
}