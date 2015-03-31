namespace WindowsFormsApplication1
{
    partial class Frmglavna
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
            this.lblpolumjer = new System.Windows.Forms.Label();
            this.lblOpseg = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.chkSpremi = new System.Windows.Forms.CheckBox();
            this.lstRezultati = new System.Windows.Forms.ListBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpolumjer
            // 
            this.lblpolumjer.AutoSize = true;
            this.lblpolumjer.Location = new System.Drawing.Point(42, 9);
            this.lblpolumjer.Name = "lblpolumjer";
            this.lblpolumjer.Size = new System.Drawing.Size(47, 13);
            this.lblpolumjer.TabIndex = 0;
            this.lblpolumjer.Tag = "";
            this.lblpolumjer.Text = "Polumjer";
            // 
            // lblOpseg
            // 
            this.lblOpseg.AutoSize = true;
            this.lblOpseg.Location = new System.Drawing.Point(42, 89);
            this.lblOpseg.Name = "lblOpseg";
            this.lblOpseg.Size = new System.Drawing.Size(38, 13);
            this.lblOpseg.TabIndex = 1;
            this.lblOpseg.Text = "Opseg";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(42, 50);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(48, 13);
            this.lblPovrsina.TabIndex = 2;
            this.lblPovrsina.Text = "Povrsina";
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(122, 12);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(122, 20);
            this.txtPolumjer.TabIndex = 3;
            this.txtPolumjer.Text = "0,00";
            this.txtPolumjer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(122, 50);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.ReadOnly = true;
            this.txtPovrsina.Size = new System.Drawing.Size(122, 20);
            this.txtPovrsina.TabIndex = 4;
            this.txtPovrsina.Text = "0,00";
            this.txtPovrsina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(122, 89);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.ReadOnly = true;
            this.txtOpseg.Size = new System.Drawing.Size(124, 20);
            this.txtOpseg.TabIndex = 5;
            this.txtOpseg.Text = "0,00";
            this.txtOpseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkSpremi
            // 
            this.chkSpremi.AutoSize = true;
            this.chkSpremi.Location = new System.Drawing.Point(122, 118);
            this.chkSpremi.Name = "chkSpremi";
            this.chkSpremi.Size = new System.Drawing.Size(88, 17);
            this.chkSpremi.TabIndex = 6;
            this.chkSpremi.Text = "Spremi u listu";
            this.chkSpremi.UseVisualStyleBackColor = true;
            // 
            // lstRezultati
            // 
            this.lstRezultati.FormattingEnabled = true;
            this.lstRezultati.Location = new System.Drawing.Point(276, 14);
            this.lstRezultati.Name = "lstRezultati";
            this.lstRezultati.Size = new System.Drawing.Size(104, 95);
            this.lstRezultati.TabIndex = 7;
            this.lstRezultati.SelectedIndexChanged += new System.EventHandler(this.lstRezultati_SelectedIndexChanged);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(122, 155);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(105, 22);
            this.btnIzracunaj.TabIndex = 8;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(122, 188);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(104, 23);
            this.btnOcisti.TabIndex = 9;
            this.btnOcisti.Text = "Ocisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // Frmglavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 223);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.lstRezultati);
            this.Controls.Add(this.chkSpremi);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.lblPovrsina);
            this.Controls.Add(this.lblOpseg);
            this.Controls.Add(this.lblpolumjer);
            this.Name = "Frmglavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTO 7/37";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpolumjer;
        private System.Windows.Forms.Label lblOpseg;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.CheckBox chkSpremi;
        private System.Windows.Forms.ListBox lstRezultati;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnOcisti;
    }
}

