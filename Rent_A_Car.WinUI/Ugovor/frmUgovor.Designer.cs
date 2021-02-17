namespace Rent_A_Car.WinUI.Ugovor
{
    partial class frmUgovor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUgovor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUgovor = new System.Windows.Forms.DataGridView();
            this.UgovorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPlacanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanBrojDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUgovor);
            this.groupBox1.Location = new System.Drawing.Point(9, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 372);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ugovori";
            // 
            // dgvUgovor
            // 
            this.dgvUgovor.AllowUserToAddRows = false;
            this.dgvUgovor.AllowUserToDeleteRows = false;
            this.dgvUgovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UgovorId,
            this.UkupnaCijena,
            this.DatumPlacanja,
            this.UkupanBrojDana,
            this.Izdano});
            this.dgvUgovor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUgovor.Location = new System.Drawing.Point(3, 16);
            this.dgvUgovor.Name = "dgvUgovor";
            this.dgvUgovor.ReadOnly = true;
            this.dgvUgovor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovor.Size = new System.Drawing.Size(440, 353);
            this.dgvUgovor.TabIndex = 0;
            this.dgvUgovor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUgovor_MouseDoubleClick);
            // 
            // UgovorId
            // 
            this.UgovorId.DataPropertyName = "RacunID";
            this.UgovorId.HeaderText = "UgovorId";
            this.UgovorId.Name = "UgovorId";
            this.UgovorId.ReadOnly = true;
            this.UgovorId.Visible = false;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "UkupnaCijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // DatumPlacanja
            // 
            this.DatumPlacanja.DataPropertyName = "DatumPlacanja";
            this.DatumPlacanja.HeaderText = "DatumPlacanja";
            this.DatumPlacanja.Name = "DatumPlacanja";
            this.DatumPlacanja.ReadOnly = true;
            // 
            // UkupanBrojDana
            // 
            this.UkupanBrojDana.DataPropertyName = "UkupanBrojDana";
            this.UkupanBrojDana.HeaderText = "UkupanBrojDana";
            this.UkupanBrojDana.Name = "UkupanBrojDana";
            this.UkupanBrojDana.ReadOnly = true;
            // 
            // Izdano
            // 
            this.Izdano.DataPropertyName = "Izdano";
            this.Izdano.HeaderText = "Izdano";
            this.Izdano.Name = "Izdano";
            this.Izdano.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(408, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUgovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUgovor";
            this.Load += new System.EventHandler(this.frmUgovor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUgovor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgovorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPlacanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanBrojDana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izdano;
    }
}