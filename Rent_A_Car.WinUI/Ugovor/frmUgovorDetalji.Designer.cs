namespace Rent_A_Car.WinUI.Ugovor
{
    partial class frmUgovorDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUgovorDetalji));
            this.Ugovor = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.UkupnaKolicina = new System.Windows.Forms.Label();
            this.txtUkupnaKolicina = new System.Windows.Forms.TextBox();
            this.UkupnaCijena = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivRezervacije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIzdat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ugovor
            // 
            this.Ugovor.AutoSize = true;
            this.Ugovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ugovor.Location = new System.Drawing.Point(175, 25);
            this.Ugovor.Name = "Ugovor";
            this.Ugovor.Size = new System.Drawing.Size(129, 39);
            this.Ugovor.TabIndex = 103;
            this.Ugovor.Text = "Ugovor";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(38, 130);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(81, 13);
            this.Datum.TabIndex = 94;
            this.Datum.Text = "Datum placanja";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(136, 127);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(265, 20);
            this.txtDatum.TabIndex = 0;
            // 
            // UkupnaKolicina
            // 
            this.UkupnaKolicina.AutoSize = true;
            this.UkupnaKolicina.Location = new System.Drawing.Point(38, 207);
            this.UkupnaKolicina.Name = "UkupnaKolicina";
            this.UkupnaKolicina.Size = new System.Drawing.Size(84, 13);
            this.UkupnaKolicina.TabIndex = 88;
            this.UkupnaKolicina.Text = "Ukupan br dana";
            // 
            // txtUkupnaKolicina
            // 
            this.txtUkupnaKolicina.Location = new System.Drawing.Point(136, 204);
            this.txtUkupnaKolicina.Name = "txtUkupnaKolicina";
            this.txtUkupnaKolicina.Size = new System.Drawing.Size(265, 20);
            this.txtUkupnaKolicina.TabIndex = 2;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSize = true;
            this.UkupnaCijena.Location = new System.Drawing.Point(38, 169);
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.Size = new System.Drawing.Size(77, 13);
            this.UkupnaCijena.TabIndex = 86;
            this.UkupnaCijena.Text = "Ukupna Cijena";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(136, 166);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(265, 20);
            this.txtUkupnaCijena.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(410, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Naziv rezervacije";
            // 
            // txtNazivRezervacije
            // 
            this.txtNazivRezervacije.Location = new System.Drawing.Point(136, 90);
            this.txtNazivRezervacije.Name = "txtNazivRezervacije";
            this.txtNazivRezervacije.Size = new System.Drawing.Size(265, 20);
            this.txtNazivRezervacije.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Racun izdat";
            // 
            // txtIzdat
            // 
            this.txtIzdat.ForeColor = System.Drawing.Color.Green;
            this.txtIzdat.Location = new System.Drawing.Point(136, 248);
            this.txtIzdat.Name = "txtIzdat";
            this.txtIzdat.Size = new System.Drawing.Size(265, 20);
            this.txtIzdat.TabIndex = 106;
            // 
            // frmUgovorDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIzdat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivRezervacije);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Ugovor);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.UkupnaKolicina);
            this.Controls.Add(this.txtUkupnaKolicina);
            this.Controls.Add(this.UkupnaCijena);
            this.Controls.Add(this.txtUkupnaCijena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUgovorDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUgovorDetalji";
            this.Load += new System.EventHandler(this.frmUgovorDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Ugovor;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label UkupnaKolicina;
        private System.Windows.Forms.TextBox txtUkupnaKolicina;
        private System.Windows.Forms.Label UkupnaCijena;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIzdat;
    }
}