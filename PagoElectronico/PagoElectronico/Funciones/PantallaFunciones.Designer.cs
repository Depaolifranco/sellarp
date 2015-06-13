namespace PagoElectronico.Funciones
{
    partial class PantallaFunciones
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
            this.buttonABMCliente = new System.Windows.Forms.Button();
            this.buttonABMCuenta = new System.Windows.Forms.Button();
            this.buttonABMUsuario = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonDeposito = new System.Windows.Forms.Button();
            this.buttonTransferencias = new System.Windows.Forms.Button();
            this.buttonRetiros = new System.Windows.Forms.Button();
            this.buttonFacturacion = new System.Windows.Forms.Button();
            this.buttonListados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonABMCliente
            // 
            this.buttonABMCliente.Location = new System.Drawing.Point(46, 40);
            this.buttonABMCliente.Name = "buttonABMCliente";
            this.buttonABMCliente.Size = new System.Drawing.Size(134, 23);
            this.buttonABMCliente.TabIndex = 0;
            this.buttonABMCliente.Text = "ABM Cliente";
            this.buttonABMCliente.UseVisualStyleBackColor = true;
            this.buttonABMCliente.Click += new System.EventHandler(this.buttonABMCliente_Click);
            // 
            // buttonABMCuenta
            // 
            this.buttonABMCuenta.Location = new System.Drawing.Point(46, 78);
            this.buttonABMCuenta.Name = "buttonABMCuenta";
            this.buttonABMCuenta.Size = new System.Drawing.Size(134, 23);
            this.buttonABMCuenta.TabIndex = 1;
            this.buttonABMCuenta.Text = "ABM Cuenta";
            this.buttonABMCuenta.UseVisualStyleBackColor = true;
            // 
            // buttonABMUsuario
            // 
            this.buttonABMUsuario.Location = new System.Drawing.Point(46, 116);
            this.buttonABMUsuario.Name = "buttonABMUsuario";
            this.buttonABMUsuario.Size = new System.Drawing.Size(134, 23);
            this.buttonABMUsuario.TabIndex = 2;
            this.buttonABMUsuario.Text = "ABM Usuario";
            this.buttonABMUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(373, 40);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(134, 23);
            this.buttonConsulta.TabIndex = 3;
            this.buttonConsulta.Text = "Consulta de saldo";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonDeposito
            // 
            this.buttonDeposito.Location = new System.Drawing.Point(373, 78);
            this.buttonDeposito.Name = "buttonDeposito";
            this.buttonDeposito.Size = new System.Drawing.Size(134, 23);
            this.buttonDeposito.TabIndex = 4;
            this.buttonDeposito.Text = "Depositos";
            this.buttonDeposito.UseVisualStyleBackColor = true;
            // 
            // buttonTransferencias
            // 
            this.buttonTransferencias.Location = new System.Drawing.Point(373, 116);
            this.buttonTransferencias.Name = "buttonTransferencias";
            this.buttonTransferencias.Size = new System.Drawing.Size(134, 23);
            this.buttonTransferencias.TabIndex = 5;
            this.buttonTransferencias.Text = "Transferencias";
            this.buttonTransferencias.UseVisualStyleBackColor = true;
            this.buttonTransferencias.Click += new System.EventHandler(this.buttonTransferencias_Click);
            // 
            // buttonRetiros
            // 
            this.buttonRetiros.Location = new System.Drawing.Point(373, 156);
            this.buttonRetiros.Name = "buttonRetiros";
            this.buttonRetiros.Size = new System.Drawing.Size(134, 23);
            this.buttonRetiros.TabIndex = 6;
            this.buttonRetiros.Text = "Retiros";
            this.buttonRetiros.UseVisualStyleBackColor = true;
            this.buttonRetiros.Click += new System.EventHandler(this.buttonRetiros_Click);
            // 
            // buttonFacturacion
            // 
            this.buttonFacturacion.Location = new System.Drawing.Point(46, 194);
            this.buttonFacturacion.Name = "buttonFacturacion";
            this.buttonFacturacion.Size = new System.Drawing.Size(134, 23);
            this.buttonFacturacion.TabIndex = 7;
            this.buttonFacturacion.Text = "Facturación";
            this.buttonFacturacion.UseVisualStyleBackColor = true;
            // 
            // buttonListados
            // 
            this.buttonListados.Location = new System.Drawing.Point(46, 232);
            this.buttonListados.Name = "buttonListados";
            this.buttonListados.Size = new System.Drawing.Size(134, 23);
            this.buttonListados.TabIndex = 8;
            this.buttonListados.Text = "Listados";
            this.buttonListados.UseVisualStyleBackColor = true;
            this.buttonListados.Click += new System.EventHandler(this.buttonListados_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ABM Rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PantallaFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonListados);
            this.Controls.Add(this.buttonFacturacion);
            this.Controls.Add(this.buttonRetiros);
            this.Controls.Add(this.buttonTransferencias);
            this.Controls.Add(this.buttonDeposito);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.buttonABMUsuario);
            this.Controls.Add(this.buttonABMCuenta);
            this.Controls.Add(this.buttonABMCliente);
            this.Name = "PantallaFunciones";
            this.Text = "Funciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonABMCliente;
        private System.Windows.Forms.Button buttonABMCuenta;
        private System.Windows.Forms.Button buttonABMUsuario;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.Button buttonDeposito;
        private System.Windows.Forms.Button buttonTransferencias;
        private System.Windows.Forms.Button buttonRetiros;
        private System.Windows.Forms.Button buttonFacturacion;
        private System.Windows.Forms.Button buttonListados;
        private System.Windows.Forms.Button button1;
    }
}