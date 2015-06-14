namespace PagoElectronico.ABM_Rol
{
    partial class PantallaModificarRol
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxFunciones = new System.Windows.Forms.GroupBox();
            this.checkBoxRetiros = new System.Windows.Forms.CheckBox();
            this.checkBoxTransferencias = new System.Windows.Forms.CheckBox();
            this.checkBoxDepositos = new System.Windows.Forms.CheckBox();
            this.checkBoxConsultas = new System.Windows.Forms.CheckBox();
            this.checkBoxFacturacion = new System.Windows.Forms.CheckBox();
            this.checkBoxListados = new System.Windows.Forms.CheckBox();
            this.checkBoxABMRol = new System.Windows.Forms.CheckBox();
            this.checkBoxABMUser = new System.Windows.Forms.CheckBox();
            this.checkBoxABMCuentas = new System.Windows.Forms.CheckBox();
            this.checkBoxABMClientes = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxFunciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxFunciones
            // 
            this.groupBoxFunciones.Controls.Add(this.checkBoxRetiros);
            this.groupBoxFunciones.Controls.Add(this.checkBoxTransferencias);
            this.groupBoxFunciones.Controls.Add(this.checkBoxDepositos);
            this.groupBoxFunciones.Controls.Add(this.checkBoxConsultas);
            this.groupBoxFunciones.Controls.Add(this.checkBoxFacturacion);
            this.groupBoxFunciones.Controls.Add(this.checkBoxListados);
            this.groupBoxFunciones.Controls.Add(this.checkBoxABMRol);
            this.groupBoxFunciones.Controls.Add(this.checkBoxABMUser);
            this.groupBoxFunciones.Controls.Add(this.checkBoxABMCuentas);
            this.groupBoxFunciones.Controls.Add(this.checkBoxABMClientes);
            this.groupBoxFunciones.Location = new System.Drawing.Point(40, 72);
            this.groupBoxFunciones.Name = "groupBoxFunciones";
            this.groupBoxFunciones.Size = new System.Drawing.Size(358, 148);
            this.groupBoxFunciones.TabIndex = 3;
            this.groupBoxFunciones.TabStop = false;
            this.groupBoxFunciones.Text = "Funciones";
            // 
            // checkBoxRetiros
            // 
            this.checkBoxRetiros.AutoSize = true;
            this.checkBoxRetiros.Location = new System.Drawing.Point(184, 121);
            this.checkBoxRetiros.Name = "checkBoxRetiros";
            this.checkBoxRetiros.Size = new System.Drawing.Size(59, 17);
            this.checkBoxRetiros.TabIndex = 9;
            this.checkBoxRetiros.Text = "Retiros";
            this.checkBoxRetiros.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransferencias
            // 
            this.checkBoxTransferencias.AutoSize = true;
            this.checkBoxTransferencias.Location = new System.Drawing.Point(184, 98);
            this.checkBoxTransferencias.Name = "checkBoxTransferencias";
            this.checkBoxTransferencias.Size = new System.Drawing.Size(96, 17);
            this.checkBoxTransferencias.TabIndex = 8;
            this.checkBoxTransferencias.Text = "Transferencias";
            this.checkBoxTransferencias.UseVisualStyleBackColor = true;
            // 
            // checkBoxDepositos
            // 
            this.checkBoxDepositos.AutoSize = true;
            this.checkBoxDepositos.Location = new System.Drawing.Point(184, 75);
            this.checkBoxDepositos.Name = "checkBoxDepositos";
            this.checkBoxDepositos.Size = new System.Drawing.Size(73, 17);
            this.checkBoxDepositos.TabIndex = 7;
            this.checkBoxDepositos.Text = "Depósitos";
            this.checkBoxDepositos.UseVisualStyleBackColor = true;
            // 
            // checkBoxConsultas
            // 
            this.checkBoxConsultas.AutoSize = true;
            this.checkBoxConsultas.Location = new System.Drawing.Point(184, 52);
            this.checkBoxConsultas.Name = "checkBoxConsultas";
            this.checkBoxConsultas.Size = new System.Drawing.Size(72, 17);
            this.checkBoxConsultas.TabIndex = 6;
            this.checkBoxConsultas.Text = "Consultas";
            this.checkBoxConsultas.UseVisualStyleBackColor = true;
            // 
            // checkBoxFacturacion
            // 
            this.checkBoxFacturacion.AutoSize = true;
            this.checkBoxFacturacion.Location = new System.Drawing.Point(184, 29);
            this.checkBoxFacturacion.Name = "checkBoxFacturacion";
            this.checkBoxFacturacion.Size = new System.Drawing.Size(82, 17);
            this.checkBoxFacturacion.TabIndex = 5;
            this.checkBoxFacturacion.Text = "Facturación";
            this.checkBoxFacturacion.UseVisualStyleBackColor = true;
            // 
            // checkBoxListados
            // 
            this.checkBoxListados.AutoSize = true;
            this.checkBoxListados.Location = new System.Drawing.Point(6, 121);
            this.checkBoxListados.Name = "checkBoxListados";
            this.checkBoxListados.Size = new System.Drawing.Size(65, 17);
            this.checkBoxListados.TabIndex = 4;
            this.checkBoxListados.Text = "Listados";
            this.checkBoxListados.UseVisualStyleBackColor = true;
            // 
            // checkBoxABMRol
            // 
            this.checkBoxABMRol.AutoSize = true;
            this.checkBoxABMRol.Location = new System.Drawing.Point(6, 98);
            this.checkBoxABMRol.Name = "checkBoxABMRol";
            this.checkBoxABMRol.Size = new System.Drawing.Size(79, 17);
            this.checkBoxABMRol.TabIndex = 3;
            this.checkBoxABMRol.Text = "ABM Roles";
            this.checkBoxABMRol.UseVisualStyleBackColor = true;
            // 
            // checkBoxABMUser
            // 
            this.checkBoxABMUser.AutoSize = true;
            this.checkBoxABMUser.Location = new System.Drawing.Point(6, 75);
            this.checkBoxABMUser.Name = "checkBoxABMUser";
            this.checkBoxABMUser.Size = new System.Drawing.Size(88, 17);
            this.checkBoxABMUser.TabIndex = 2;
            this.checkBoxABMUser.Text = "ABM Usuario";
            this.checkBoxABMUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxABMCuentas
            // 
            this.checkBoxABMCuentas.AutoSize = true;
            this.checkBoxABMCuentas.Location = new System.Drawing.Point(6, 52);
            this.checkBoxABMCuentas.Name = "checkBoxABMCuentas";
            this.checkBoxABMCuentas.Size = new System.Drawing.Size(94, 17);
            this.checkBoxABMCuentas.TabIndex = 1;
            this.checkBoxABMCuentas.Text = "ABM  Cuentas";
            this.checkBoxABMCuentas.UseVisualStyleBackColor = true;
            // 
            // checkBoxABMClientes
            // 
            this.checkBoxABMClientes.AutoSize = true;
            this.checkBoxABMClientes.Location = new System.Drawing.Point(6, 29);
            this.checkBoxABMClientes.Name = "checkBoxABMClientes";
            this.checkBoxABMClientes.Size = new System.Drawing.Size(89, 17);
            this.checkBoxABMClientes.TabIndex = 0;
            this.checkBoxABMClientes.Text = "ABM Clientes";
            this.checkBoxABMClientes.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(69, 269);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(208, 269);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // PantallaModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 374);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBoxFunciones);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "PantallaModificarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.PantallaModificarRol_Load);
            this.groupBoxFunciones.ResumeLayout(false);
            this.groupBoxFunciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxFunciones;
        private System.Windows.Forms.CheckBox checkBoxRetiros;
        private System.Windows.Forms.CheckBox checkBoxTransferencias;
        private System.Windows.Forms.CheckBox checkBoxDepositos;
        private System.Windows.Forms.CheckBox checkBoxConsultas;
        private System.Windows.Forms.CheckBox checkBoxFacturacion;
        private System.Windows.Forms.CheckBox checkBoxListados;
        private System.Windows.Forms.CheckBox checkBoxABMRol;
        private System.Windows.Forms.CheckBox checkBoxABMUser;
        private System.Windows.Forms.CheckBox checkBoxABMCuentas;
        private System.Windows.Forms.CheckBox checkBoxABMClientes;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}