namespace Rent_A_Car.WinUI.Kategorija
{
    partial class frmKategorija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorija));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.KategorijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijent);
            this.groupBox1.Location = new System.Drawing.Point(10, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorija";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.AllowUserToAddRows = false;
            this.dgvKlijent.AllowUserToDeleteRows = false;
            this.dgvKlijent.BackgroundColor = System.Drawing.Color.White;
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaID,
            this.Oznaka,
            this.Naziv,
            this.Opis,
            this.MinDob});
            this.dgvKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijent.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.ReadOnly = true;
            this.dgvKlijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijent.Size = new System.Drawing.Size(554, 282);
            this.dgvKlijent.TabIndex = 0;
            this.dgvKlijent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlijent_MouseDoubleClick);
            // 
            // KategorijaID
            // 
            this.KategorijaID.DataPropertyName = "KategorijaID";
            this.KategorijaID.HeaderText = "KategorijaID";
            this.KategorijaID.Name = "KategorijaID";
            this.KategorijaID.ReadOnly = true;
            this.KategorijaID.Visible = false;
            this.KategorijaID.Width = 130;
            // 
            // Oznaka
            // 
            this.Oznaka.DataPropertyName = "Oznaka";
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.ReadOnly = true;
            this.Oznaka.Width = 130;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 130;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 150;
            // 
            // MinDob
            // 
            this.MinDob.DataPropertyName = "MinDob";
            this.MinDob.HeaderText = "MinDob";
            this.MinDob.Name = "MinDob";
            this.MinDob.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(540, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKategorija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKategorija";
            this.Load += new System.EventHandler(this.frmKategorija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinDob;
    }
}