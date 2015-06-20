namespace PagoElectronico.Asociar_Desasociar_Tarjeta
{
    partial class Modificar_Tarjeta
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
            this.labelCamposModificables = new System.Windows.Forms.Label();
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCamposModificables
            // 
            this.labelCamposModificables.AutoSize = true;
            this.labelCamposModificables.Location = new System.Drawing.Point(12, 9);
            this.labelCamposModificables.Name = "labelCamposModificables";
            this.labelCamposModificables.Size = new System.Drawing.Size(107, 13);
            this.labelCamposModificables.TabIndex = 0;
            this.labelCamposModificables.Text = "Campos Modificables";
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Location = new System.Drawing.Point(15, 124);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(104, 23);
            this.buttonRestaurar.TabIndex = 1;
            this.buttonRestaurar.Text = "Restaurar Campos";
            this.buttonRestaurar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(144, 124);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(104, 23);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // Modificar_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonRestaurar);
            this.Controls.Add(this.labelCamposModificables);
            this.Name = "Modificar_Tarjeta";
            this.Text = "Modificar Tarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCamposModificables;
        private System.Windows.Forms.Button buttonRestaurar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}