namespace PagoElectronico.Facturacion
{
    partial class ModificarFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNroFactura = new System.Windows.Forms.TextBox();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.textFechaFacturacion = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Facturacion";
            // 
            // textNroFactura
            // 
            this.textNroFactura.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNroFactura.Location = new System.Drawing.Point(81, 6);
            this.textNroFactura.Name = "textNroFactura";
            this.textNroFactura.ReadOnly = true;
            this.textNroFactura.Size = new System.Drawing.Size(100, 20);
            this.textNroFactura.TabIndex = 3;
            // 
            // textCliente
            // 
            this.textCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textCliente.Location = new System.Drawing.Point(276, 6);
            this.textCliente.Name = "textCliente";
            this.textCliente.ReadOnly = true;
            this.textCliente.Size = new System.Drawing.Size(100, 20);
            this.textCliente.TabIndex = 4;
            // 
            // textFechaFacturacion
            // 
            this.textFechaFacturacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textFechaFacturacion.Location = new System.Drawing.Point(547, 6);
            this.textFechaFacturacion.Name = "textFechaFacturacion";
            this.textFechaFacturacion.ReadOnly = true;
            this.textFechaFacturacion.Size = new System.Drawing.Size(100, 20);
            this.textFechaFacturacion.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(632, 212);
            this.listBox1.TabIndex = 6;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(276, 303);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // ModificarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 368);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textFechaFacturacion);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.textNroFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarFactura";
            this.Text = "ModificarFactura";
            this.Load += new System.EventHandler(this.ModificarFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNroFactura;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.TextBox textFechaFacturacion;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonModificar;
    }
}