namespace PagoElectronico.ABM_Cliente
{
    partial class PantallaBuscarClientes
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelDoc = new System.Windows.Forms.Label();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.tablaListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaListado)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(26, 25);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(90, 22);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(90, 48);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 2;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(26, 51);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Mail:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(483, 41);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(587, 41);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Location = new System.Drawing.Point(215, 25);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(82, 13);
            this.labelDoc.TabIndex = 7;
            this.labelDoc.Text = "DNI/Pasaporte:";
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(308, 22);
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoc.TabIndex = 8;
            // 
            // tablaListado
            // 
            this.tablaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaListado.Location = new System.Drawing.Point(29, 99);
            this.tablaListado.Name = "tablaListado";
            this.tablaListado.Size = new System.Drawing.Size(633, 367);
            this.tablaListado.TabIndex = 9;
            // 
            // PantallaBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 491);
            this.Controls.Add(this.tablaListado);
            this.Controls.Add(this.textBoxDoc);
            this.Controls.Add(this.labelDoc);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Name = "PantallaBuscarClientes";
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.PantallaListados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.DataGridView tablaListado;
    }
}