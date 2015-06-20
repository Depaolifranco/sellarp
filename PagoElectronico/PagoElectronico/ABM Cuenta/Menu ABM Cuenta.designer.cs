namespace PagoElectronico.ABM_Cuenta
{
    partial class FormMainABMCuenta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCuentaToolStripMenuItem,
            this.modificarCuentaToolStripMenuItem,
            this.cerrarCuentaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nuevaCuentaToolStripMenuItem
            // 
            this.nuevaCuentaToolStripMenuItem.Name = "nuevaCuentaToolStripMenuItem";
            this.nuevaCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nuevaCuentaToolStripMenuItem.Text = "Nueva Cuenta";
            this.nuevaCuentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCuentaToolStripMenuItem_Click);
            // 
            // modificarCuentaToolStripMenuItem
            // 
            this.modificarCuentaToolStripMenuItem.Name = "modificarCuentaToolStripMenuItem";
            this.modificarCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modificarCuentaToolStripMenuItem.Text = "Modificar Cuenta";
            this.modificarCuentaToolStripMenuItem.Click += new System.EventHandler(this.modificarCuentaToolStripMenuItem_Click);
            // 
            // cerrarCuentaToolStripMenuItem
            // 
            this.cerrarCuentaToolStripMenuItem.Name = "cerrarCuentaToolStripMenuItem";
            this.cerrarCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cerrarCuentaToolStripMenuItem.Text = "Cerrar Cuenta";
            this.cerrarCuentaToolStripMenuItem.Click += new System.EventHandler(this.cerrarCuentaToolStripMenuItem_Click);
            // 
            // FormMainABMCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainABMCuenta";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FormMainABMCuenta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCuentaToolStripMenuItem;
    }
}