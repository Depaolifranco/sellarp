namespace PagoElectronico
{
    partial class PantallaInicio
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
            this.labelMensaje = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.pictureBoxPagoElec = new System.Windows.Forms.PictureBox();
            this.pictureBoxUtn = new System.Windows.Forms.PictureBox();
            this.labelPagoElec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPagoElec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.Location = new System.Drawing.Point(144, 213);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(105, 24);
            this.labelMensaje.TabIndex = 0;
            this.labelMensaje.Text = "Bienvenido";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(161, 256);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 1;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(161, 285);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrarse.TabIndex = 2;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // pictureBoxPagoElec
            // 
            this.pictureBoxPagoElec.Image = global::PagoElectronico.Properties.Resources.pago_electronico;
            this.pictureBoxPagoElec.Location = new System.Drawing.Point(21, 97);
            this.pictureBoxPagoElec.Name = "pictureBoxPagoElec";
            this.pictureBoxPagoElec.Size = new System.Drawing.Size(128, 96);
            this.pictureBoxPagoElec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPagoElec.TabIndex = 4;
            this.pictureBoxPagoElec.TabStop = false;
            // 
            // pictureBoxUtn
            // 
            this.pictureBoxUtn.Image = global::PagoElectronico.Properties.Resources.utnba;
            this.pictureBoxUtn.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxUtn.Name = "pictureBoxUtn";
            this.pictureBoxUtn.Size = new System.Drawing.Size(326, 70);
            this.pictureBoxUtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUtn.TabIndex = 3;
            this.pictureBoxUtn.TabStop = false;
            // 
            // labelPagoElec
            // 
            this.labelPagoElec.AutoSize = true;
            this.labelPagoElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagoElec.Location = new System.Drawing.Point(155, 113);
            this.labelPagoElec.Name = "labelPagoElec";
            this.labelPagoElec.Size = new System.Drawing.Size(219, 31);
            this.labelPagoElec.TabIndex = 5;
            this.labelPagoElec.Text = "Pago Electrónico";
            this.labelPagoElec.Click += new System.EventHandler(this.labelPagoElec_Click);
            // 
            // PantallaInicio
            // 
            this.AcceptButton = this.buttonIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 345);
            this.Controls.Add(this.labelPagoElec);
            this.Controls.Add(this.pictureBoxPagoElec);
            this.Controls.Add(this.pictureBoxUtn);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelMensaje);
            this.Name = "PantallaInicio";
            this.Text = "Pago Electronico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPagoElec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.PictureBox pictureBoxUtn;
        private System.Windows.Forms.PictureBox pictureBoxPagoElec;
        private System.Windows.Forms.Label labelPagoElec;
    }
}

