namespace ArreglosyMatrices
{
    partial class Ejercicio2
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
            this.txtTamañoM = new System.Windows.Forms.TextBox();
            this.btnTamañoM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtTamañoM
            // 
            this.txtTamañoM.Location = new System.Drawing.Point(50, 55);
            this.txtTamañoM.Name = "txtTamañoM";
            this.txtTamañoM.Size = new System.Drawing.Size(115, 20);
            this.txtTamañoM.TabIndex = 0;
            // 
            // btnTamañoM
            // 
            this.btnTamañoM.Location = new System.Drawing.Point(172, 55);
            this.btnTamañoM.Name = "btnTamañoM";
            this.btnTamañoM.Size = new System.Drawing.Size(82, 19);
            this.btnTamañoM.TabIndex = 1;
            this.btnTamañoM.Text = "Aceptar";
            this.btnTamañoM.UseVisualStyleBackColor = true;
            this.btnTamañoM.Click += new System.EventHandler(this.btnTamañoM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "numero de columnas y filas";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(306, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 274);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTamañoM);
            this.Controls.Add(this.txtTamañoM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTamañoM;
        private System.Windows.Forms.Button btnTamañoM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}