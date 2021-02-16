namespace Rent_A_Car.WinUI.Kategorija
{
    partial class frmKategorijaDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorijaDetalji));
            this.Kategorija = new System.Windows.Forms.Label();
            this.Oznaka = new System.Windows.Forms.Label();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.MinimalnaDob = new System.Windows.Forms.Label();
            this.txtMinDob = new System.Windows.Forms.TextBox();
            this.Opis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSize = true;
            this.Kategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategorija.Location = new System.Drawing.Point(145, 9);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(173, 39);
            this.Kategorija.TabIndex = 103;
            this.Kategorija.Text = "Kategorija";
            this.Kategorija.Click += new System.EventHandler(this.label1_Click);
            // 
            // Oznaka
            // 
            this.Oznaka.AutoSize = true;
            this.Oznaka.Location = new System.Drawing.Point(54, 86);
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.Size = new System.Drawing.Size(44, 13);
            this.Oznaka.TabIndex = 94;
            this.Oznaka.Text = "Oznaka";
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(152, 79);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(265, 20);
            this.txtOznaka.TabIndex = 0;
            // 
            // MinimalnaDob
            // 
            this.MinimalnaDob.AutoSize = true;
            this.MinimalnaDob.Location = new System.Drawing.Point(54, 206);
            this.MinimalnaDob.Name = "MinimalnaDob";
            this.MinimalnaDob.Size = new System.Drawing.Size(77, 13);
            this.MinimalnaDob.TabIndex = 90;
            this.MinimalnaDob.Text = "Minimalna Dob";
            // 
            // txtMinDob
            // 
            this.txtMinDob.Location = new System.Drawing.Point(152, 203);
            this.txtMinDob.Name = "txtMinDob";
            this.txtMinDob.Size = new System.Drawing.Size(265, 20);
            this.txtMinDob.TabIndex = 3;
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Location = new System.Drawing.Point(54, 163);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(28, 13);
            this.Opis.TabIndex = 88;
            this.Opis.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(152, 160);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(265, 20);
            this.txtOpis.TabIndex = 2;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(54, 125);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(34, 13);
            this.Naziv.TabIndex = 86;
            this.Naziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(152, 122);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(425, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmKategorijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Kategorija);
            this.Controls.Add(this.Oznaka);
            this.Controls.Add(this.txtOznaka);
            this.Controls.Add(this.MinimalnaDob);
            this.Controls.Add(this.txtMinDob);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKategorijaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKategorijaDetalji";
            this.Load += new System.EventHandler(this.frmKategorijaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Kategorija;
        private System.Windows.Forms.Label Oznaka;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label MinimalnaDob;
        private System.Windows.Forms.TextBox txtMinDob;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnExit;
    }
}