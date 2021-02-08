namespace Rent_A_Car.WinUI
{
    partial class frmLocirajVoziloDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocirajVoziloDetalji));
            this.btnExit = new System.Windows.Forms.Button();
            this.Prihvaceno = new System.Windows.Forms.Label();
            this.txtPrihvaceno = new System.Windows.Forms.TextBox();
            this.PostanskiBroj = new System.Windows.Forms.Label();
            this.txtOdgovoreno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(336, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Prihvaceno
            // 
            this.Prihvaceno.AutoSize = true;
            this.Prihvaceno.Location = new System.Drawing.Point(8, 83);
            this.Prihvaceno.Name = "Prihvaceno";
            this.Prihvaceno.Size = new System.Drawing.Size(61, 13);
            this.Prihvaceno.TabIndex = 98;
            this.Prihvaceno.Text = "Prihvaceno";
            // 
            // txtPrihvaceno
            // 
            this.txtPrihvaceno.Location = new System.Drawing.Point(106, 80);
            this.txtPrihvaceno.Name = "txtPrihvaceno";
            this.txtPrihvaceno.Size = new System.Drawing.Size(201, 20);
            this.txtPrihvaceno.TabIndex = 97;
            // 
            // PostanskiBroj
            // 
            this.PostanskiBroj.AutoSize = true;
            this.PostanskiBroj.Location = new System.Drawing.Point(8, 122);
            this.PostanskiBroj.Name = "PostanskiBroj";
            this.PostanskiBroj.Size = new System.Drawing.Size(66, 13);
            this.PostanskiBroj.TabIndex = 96;
            this.PostanskiBroj.Text = "Odgovoreno";
            // 
            // txtOdgovoreno
            // 
            this.txtOdgovoreno.Location = new System.Drawing.Point(106, 119);
            this.txtOdgovoreno.Name = "txtOdgovoreno";
            this.txtOdgovoreno.Size = new System.Drawing.Size(201, 20);
            this.txtOdgovoreno.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Vozilo";
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(106, 164);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(201, 20);
            this.txtVozilo.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Klijent";
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(106, 203);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(201, 20);
            this.txtKlijent.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Zaposlenik";
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(106, 247);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(201, 20);
            this.txtZaposlenik.TabIndex = 103;
            // 
            // frmLocirajVoziloDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.Prihvaceno);
            this.Controls.Add(this.txtPrihvaceno);
            this.Controls.Add(this.PostanskiBroj);
            this.Controls.Add(this.txtOdgovoreno);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocirajVoziloDetalji";
            this.Text = "frmLocirajVoziloDetalji";
            this.Load += new System.EventHandler(this.frmLocirajVoziloDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Prihvaceno;
        private System.Windows.Forms.TextBox txtPrihvaceno;
        private System.Windows.Forms.Label PostanskiBroj;
        private System.Windows.Forms.TextBox txtOdgovoreno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZaposlenik;
    }
}