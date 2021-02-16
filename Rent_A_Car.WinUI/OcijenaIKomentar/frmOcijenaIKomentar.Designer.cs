namespace Rent_A_Car.WinUI.OcijenaIKomentar
{
    partial class frmOcijenaIKomentar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcijenaIKomentar));
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.DojmoviZahtjeviID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivZahtjeva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dojam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odgovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(711, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijent);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 351);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocijene i komentari";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.AllowUserToAddRows = false;
            this.dgvKlijent.AllowUserToDeleteRows = false;
            this.dgvKlijent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DojmoviZahtjeviID,
            this.Klijent,
            this.NazivZahtjeva,
            this.Dojam,
            this.Odgovor,
            this.RezervacijaID});
            this.dgvKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijent.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.ReadOnly = true;
            this.dgvKlijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijent.Size = new System.Drawing.Size(740, 332);
            this.dgvKlijent.TabIndex = 0;
            this.dgvKlijent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlijent_MouseDoubleClick);
            // 
            // DojmoviZahtjeviID
            // 
            this.DojmoviZahtjeviID.DataPropertyName = "DojmoviZahtjeviID";
            this.DojmoviZahtjeviID.HeaderText = "DojmoviZahtjeviID";
            this.DojmoviZahtjeviID.Name = "DojmoviZahtjeviID";
            this.DojmoviZahtjeviID.ReadOnly = true;
            this.DojmoviZahtjeviID.Visible = false;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "KlijentKorisnickoIme";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            this.Klijent.Width = 150;
            // 
            // NazivZahtjeva
            // 
            this.NazivZahtjeva.DataPropertyName = "NazivZahtjeva";
            this.NazivZahtjeva.HeaderText = "Naziv Zahtjeva";
            this.NazivZahtjeva.Name = "NazivZahtjeva";
            this.NazivZahtjeva.ReadOnly = true;
            this.NazivZahtjeva.Width = 150;
            // 
            // Dojam
            // 
            this.Dojam.DataPropertyName = "Dojam";
            this.Dojam.FillWeight = 120F;
            this.Dojam.HeaderText = "Dojam";
            this.Dojam.Name = "Dojam";
            this.Dojam.ReadOnly = true;
            this.Dojam.Width = 150;
            // 
            // Odgovor
            // 
            this.Odgovor.DataPropertyName = "Odgovor";
            this.Odgovor.HeaderText = "Odgovor";
            this.Odgovor.Name = "Odgovor";
            this.Odgovor.ReadOnly = true;
            this.Odgovor.Width = 150;
            // 
            // RezervacijaID
            // 
            this.RezervacijaID.DataPropertyName = "RezervacijaID";
            this.RezervacijaID.HeaderText = "RezervacijaID";
            this.RezervacijaID.Name = "RezervacijaID";
            this.RezervacijaID.ReadOnly = true;
            // 
            // frmOcijenaIKomentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 441);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOcijenaIKomentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOcijenaIKomentar";
            this.Load += new System.EventHandler(this.frmOcijenaIKomentar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DojmoviZahtjeviID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivZahtjeva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dojam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odgovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaID;
    }
}