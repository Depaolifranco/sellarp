namespace PagoElectronico.Retiros
{
    partial class Form
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNroDoc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.comboBoxTipoMoneda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta";
            // 
            // labelNroDoc
            // 
            this.labelNroDoc.AutoSize = true;
            this.labelNroDoc.Location = new System.Drawing.Point(30, 79);
            this.labelNroDoc.Name = "labelNroDoc";
            this.labelNroDoc.Size = new System.Drawing.Size(115, 13);
            this.labelNroDoc.TabIndex = 3;
            this.labelNroDoc.Text = "Numero de documento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(123, 231);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(252, 231);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(123, 23);
            this.buttonImprimir.TabIndex = 6;
            this.buttonImprimir.Text = "Imprimir cheque";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Importe:";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(81, 127);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(100, 20);
            this.textBoxImporte.TabIndex = 8;
            // 
            // comboBoxTipoMoneda
            // 
            this.comboBoxTipoMoneda.FormattingEnabled = true;
            this.comboBoxTipoMoneda.Items.AddRange(new object[] {
            "U$S"});
            this.comboBoxTipoMoneda.Location = new System.Drawing.Point(187, 127);
            this.comboBoxTipoMoneda.Name = "comboBoxTipoMoneda";
            this.comboBoxTipoMoneda.Size = new System.Drawing.Size(73, 21);
            this.comboBoxTipoMoneda.TabIndex = 9;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 423);
            this.Controls.Add(this.comboBoxTipoMoneda);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNroDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form";
            this.Text = "Extracciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNroDoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.ComboBox comboBoxTipoMoneda;

    }
}