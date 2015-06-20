namespace PagoElectronico.Asociar_Desasociar_Tarjeta
{
    partial class Formulario_De_Alta
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumoeroTarjeta = new System.Windows.Forms.Label();
            this.labelEmisor = new System.Windows.Forms.Label();
            this.labelFechaEmision = new System.Windows.Forms.Label();
            this.labelFechaVenci = new System.Windows.Forms.Label();
            this.labelCodigoDeSeguridad = new System.Windows.Forms.Label();
            this.textBoxNroTarjeta = new System.Windows.Forms.TextBox();
            this.comboBoxEmisor = new System.Windows.Forms.ComboBox();
            this.textBoxFechaEmision = new System.Windows.Forms.TextBox();
            this.textBoxFechaVenci = new System.Windows.Forms.TextBox();
            this.textBoxCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonAsociar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete el formulario";
            // 
            // labelNumoeroTarjeta
            // 
            this.labelNumoeroTarjeta.AutoSize = true;
            this.labelNumoeroTarjeta.Location = new System.Drawing.Point(12, 35);
            this.labelNumoeroTarjeta.Name = "labelNumoeroTarjeta";
            this.labelNumoeroTarjeta.Size = new System.Drawing.Size(95, 13);
            this.labelNumoeroTarjeta.TabIndex = 1;
            this.labelNumoeroTarjeta.Text = "Numero de Tarjeta";
            // 
            // labelEmisor
            // 
            this.labelEmisor.AutoSize = true;
            this.labelEmisor.Location = new System.Drawing.Point(12, 61);
            this.labelEmisor.Name = "labelEmisor";
            this.labelEmisor.Size = new System.Drawing.Size(38, 13);
            this.labelEmisor.TabIndex = 2;
            this.labelEmisor.Text = "Emisor";
            // 
            // labelFechaEmision
            // 
            this.labelFechaEmision.AutoSize = true;
            this.labelFechaEmision.Location = new System.Drawing.Point(12, 91);
            this.labelFechaEmision.Name = "labelFechaEmision";
            this.labelFechaEmision.Size = new System.Drawing.Size(91, 13);
            this.labelFechaEmision.TabIndex = 3;
            this.labelFechaEmision.Text = "Fecha de Emision";
            // 
            // labelFechaVenci
            // 
            this.labelFechaVenci.AutoSize = true;
            this.labelFechaVenci.Location = new System.Drawing.Point(12, 118);
            this.labelFechaVenci.Name = "labelFechaVenci";
            this.labelFechaVenci.Size = new System.Drawing.Size(113, 13);
            this.labelFechaVenci.TabIndex = 4;
            this.labelFechaVenci.Text = "Fecha de Vencimiento";
            // 
            // labelCodigoDeSeguridad
            // 
            this.labelCodigoDeSeguridad.AutoSize = true;
            this.labelCodigoDeSeguridad.Location = new System.Drawing.Point(12, 146);
            this.labelCodigoDeSeguridad.Name = "labelCodigoDeSeguridad";
            this.labelCodigoDeSeguridad.Size = new System.Drawing.Size(102, 13);
            this.labelCodigoDeSeguridad.TabIndex = 5;
            this.labelCodigoDeSeguridad.Text = "CodigoDeSeguridad";
            // 
            // textBoxNroTarjeta
            // 
            this.textBoxNroTarjeta.Location = new System.Drawing.Point(142, 32);
            this.textBoxNroTarjeta.Name = "textBoxNroTarjeta";
            this.textBoxNroTarjeta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroTarjeta.TabIndex = 6;
            this.textBoxNroTarjeta.TextChanged += new System.EventHandler(this.textBoxNroTarjeta_TextChanged);
            // 
            // comboBoxEmisor
            // 
            this.comboBoxEmisor.FormattingEnabled = true;
            this.comboBoxEmisor.Location = new System.Drawing.Point(142, 58);
            this.comboBoxEmisor.Name = "comboBoxEmisor";
            this.comboBoxEmisor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmisor.TabIndex = 7;
            // 
            // textBoxFechaEmision
            // 
            this.textBoxFechaEmision.Location = new System.Drawing.Point(142, 88);
            this.textBoxFechaEmision.Name = "textBoxFechaEmision";
            this.textBoxFechaEmision.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaEmision.TabIndex = 8;
            this.textBoxFechaEmision.Text = "dd/mm/yyyy";
            // 
            // textBoxFechaVenci
            // 
            this.textBoxFechaVenci.Location = new System.Drawing.Point(142, 115);
            this.textBoxFechaVenci.Name = "textBoxFechaVenci";
            this.textBoxFechaVenci.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaVenci.TabIndex = 9;
            this.textBoxFechaVenci.Text = "dd/mm/yyyy";
            // 
            // textBoxCodigoSeguridad
            // 
            this.textBoxCodigoSeguridad.Location = new System.Drawing.Point(142, 143);
            this.textBoxCodigoSeguridad.Name = "textBoxCodigoSeguridad";
            this.textBoxCodigoSeguridad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoSeguridad.TabIndex = 10;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(39, 198);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonAsociar
            // 
            this.buttonAsociar.Location = new System.Drawing.Point(188, 198);
            this.buttonAsociar.Name = "buttonAsociar";
            this.buttonAsociar.Size = new System.Drawing.Size(75, 23);
            this.buttonAsociar.TabIndex = 12;
            this.buttonAsociar.Text = "Asociar";
            this.buttonAsociar.UseVisualStyleBackColor = true;
            this.buttonAsociar.Click += new System.EventHandler(this.buttonAsociar_Click);
            // 
            // Formulario_De_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.buttonAsociar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxCodigoSeguridad);
            this.Controls.Add(this.textBoxFechaVenci);
            this.Controls.Add(this.textBoxFechaEmision);
            this.Controls.Add(this.comboBoxEmisor);
            this.Controls.Add(this.textBoxNroTarjeta);
            this.Controls.Add(this.labelCodigoDeSeguridad);
            this.Controls.Add(this.labelFechaVenci);
            this.Controls.Add(this.labelFechaEmision);
            this.Controls.Add(this.labelEmisor);
            this.Controls.Add(this.labelNumoeroTarjeta);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_De_Alta";
            this.Text = "Asociar Tarjeta";
            this.Load += new System.EventHandler(this.Formulario_De_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumoeroTarjeta;
        private System.Windows.Forms.Label labelEmisor;
        private System.Windows.Forms.Label labelFechaEmision;
        private System.Windows.Forms.Label labelFechaVenci;
        private System.Windows.Forms.Label labelCodigoDeSeguridad;
        private System.Windows.Forms.TextBox textBoxNroTarjeta;
        private System.Windows.Forms.ComboBox comboBoxEmisor;
        private System.Windows.Forms.TextBox textBoxFechaEmision;
        private System.Windows.Forms.TextBox textBoxFechaVenci;
        private System.Windows.Forms.TextBox textBoxCodigoSeguridad;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonAsociar;
    }
}