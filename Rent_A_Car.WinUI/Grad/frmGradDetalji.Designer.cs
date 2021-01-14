namespace Rent_A_Car.WinUI.Grad
{
    partial class frmGradDetalji
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
            this.txtNazad = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.Grada = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.PostanskiBroj = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNazad
            // 
            this.txtNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazad.ForeColor = System.Drawing.Color.White;
            this.txtNazad.Location = new System.Drawing.Point(54, 183);
            this.txtNazad.Name = "txtNazad";
            this.txtNazad.Size = new System.Drawing.Size(168, 58);
            this.txtNazad.TabIndex = 105;
            this.txtNazad.Text = "Nazad";
            this.txtNazad.UseVisualStyleBackColor = false;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(250, 184);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(167, 57);
            this.btnSnimi.TabIndex = 104;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            // 
            // Grada
            // 
            this.Grada.AutoSize = true;
            this.Grada.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grada.Location = new System.Drawing.Point(192, 18);
            this.Grada.Name = "Grada";
            this.Grada.Size = new System.Drawing.Size(94, 39);
            this.Grada.TabIndex = 103;
            this.Grada.Text = "Grad";
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(51, 91);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(34, 13);
            this.Naziv.TabIndex = 94;
            this.Naziv.Text = "Naziv";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(149, 88);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(265, 20);
            this.txtKorisnickoIme.TabIndex = 93;
            // 
            // PostanskiBroj
            // 
            this.PostanskiBroj.AutoSize = true;
            this.PostanskiBroj.Location = new System.Drawing.Point(51, 130);
            this.PostanskiBroj.Name = "PostanskiBroj";
            this.PostanskiBroj.Size = new System.Drawing.Size(73, 13);
            this.PostanskiBroj.TabIndex = 86;
            this.PostanskiBroj.Text = "Postanski broj";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(149, 127);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(265, 20);
            this.txtIme.TabIndex = 85;
            // 
            // frmGradDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.txtNazad);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.Grada);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.PostanskiBroj);
            this.Controls.Add(this.txtIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGradDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGradDetalji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtNazad;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label Grada;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label PostanskiBroj;
        private System.Windows.Forms.TextBox txtIme;
    }
}