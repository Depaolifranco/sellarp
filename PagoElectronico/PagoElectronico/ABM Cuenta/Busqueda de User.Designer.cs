namespace PagoElectronico.ABM_Cuenta
{
    partial class FormBusquedaUserxAlta
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
            this.labelBuscaUsr = new System.Windows.Forms.Label();
            this.textBoxBuscarUsr = new System.Windows.Forms.TextBox();
            this.buttonBuscarUsr = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderUsername = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // labelBuscaUsr
            // 
            this.labelBuscaUsr.AutoSize = true;
            this.labelBuscaUsr.Location = new System.Drawing.Point(3, 15);
            this.labelBuscaUsr.Name = "labelBuscaUsr";
            this.labelBuscaUsr.Size = new System.Drawing.Size(93, 13);
            this.labelBuscaUsr.TabIndex = 0;
            this.labelBuscaUsr.Text = "Ingrese Username";
            // 
            // textBoxBuscarUsr
            // 
            this.textBoxBuscarUsr.Location = new System.Drawing.Point(102, 12);
            this.textBoxBuscarUsr.Name = "textBoxBuscarUsr";
            this.textBoxBuscarUsr.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscarUsr.TabIndex = 1;
            // 
            // buttonBuscarUsr
            // 
            this.buttonBuscarUsr.Location = new System.Drawing.Point(208, 9);
            this.buttonBuscarUsr.Name = "buttonBuscarUsr";
            this.buttonBuscarUsr.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarUsr.TabIndex = 2;
            this.buttonBuscarUsr.Text = "Buscar";
            this.buttonBuscarUsr.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUsername});
            this.listView1.Location = new System.Drawing.Point(6, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // columnHeaderUsername
            // 
            this.columnHeaderUsername.Text = "Username";
            // 
            // FormBusquedaUserxAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonBuscarUsr);
            this.Controls.Add(this.textBoxBuscarUsr);
            this.Controls.Add(this.labelBuscaUsr);
            this.Name = "FormBusquedaUserxAlta";
            this.Text = "Buscar Usuario";
            this.Load += new System.EventHandler(this.FormBusquedaUserxAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuscaUsr;
        private System.Windows.Forms.TextBox textBoxBuscarUsr;
        private System.Windows.Forms.Button buttonBuscarUsr;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
    }
}