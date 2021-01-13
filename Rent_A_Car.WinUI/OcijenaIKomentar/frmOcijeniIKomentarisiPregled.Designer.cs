namespace Rent_A_Car.WinUI.OcijenaIKomentar
{
    partial class frmOcijeniIKomentarisiPregled
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Automobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaAutomobila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacijeOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacijeDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijent);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 321);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocijene i komentari";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.AllowUserToAddRows = false;
            this.dgvKlijent.AllowUserToDeleteRows = false;
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentID,
            this.Automobil,
            this.VrstaAutomobila,
            this.DatumRezervacijeOD,
            this.DatumRezervacijeDO,
            this.Komentar,
            this.Ocijena});
            this.dgvKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijent.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.ReadOnly = true;
            this.dgvKlijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijent.Size = new System.Drawing.Size(698, 302);
            this.dgvKlijent.TabIndex = 0;
            // 
            // KlijentID
            // 
            this.KlijentID.DataPropertyName = "KlijentID";
            this.KlijentID.HeaderText = "KlijentID";
            this.KlijentID.Name = "KlijentID";
            this.KlijentID.ReadOnly = true;
            this.KlijentID.Visible = false;
            // 
            // Automobil
            // 
            this.Automobil.HeaderText = "Automobil";
            this.Automobil.Name = "Automobil";
            this.Automobil.ReadOnly = true;
            // 
            // VrstaAutomobila
            // 
            this.VrstaAutomobila.HeaderText = "VrstaAutomobila";
            this.VrstaAutomobila.Name = "VrstaAutomobila";
            this.VrstaAutomobila.ReadOnly = true;
            // 
            // DatumRezervacijeOD
            // 
            this.DatumRezervacijeOD.HeaderText = "DatumRezervacijeOD";
            this.DatumRezervacijeOD.Name = "DatumRezervacijeOD";
            this.DatumRezervacijeOD.ReadOnly = true;
            // 
            // DatumRezervacijeDO
            // 
            this.DatumRezervacijeDO.HeaderText = "DatumRezervacijeDO";
            this.DatumRezervacijeDO.Name = "DatumRezervacijeDO";
            this.DatumRezervacijeDO.ReadOnly = true;
            // 
            // Komentar
            // 
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            // 
            // Ocijena
            // 
            this.Ocijena.DataPropertyName = "Ocijena";
            this.Ocijena.HeaderText = "Ocijena";
            this.Ocijena.Name = "Ocijena";
            this.Ocijena.ReadOnly = true;
            // 
            // frmOcijeniIKomentarisiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 368);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOcijeniIKomentarisiPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOcijeniIKomentarisiPregled";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaAutomobila;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacijeOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacijeDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocijena;
    }
}