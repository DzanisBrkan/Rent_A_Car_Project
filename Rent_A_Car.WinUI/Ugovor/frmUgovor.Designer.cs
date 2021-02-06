﻿namespace Rent_A_Car.WinUI.Ugovor
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUgovor = new System.Windows.Forms.DataGridView();
            this.UgovorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaAutomobila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 48);
            this.txtPretraga.Multiline = true;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(322, 37);
            this.txtPretraga.TabIndex = 8;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Location = new System.Drawing.Point(340, 48);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(111, 37);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUgovor);
            this.groupBox1.Location = new System.Drawing.Point(9, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 321);
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
            this.DatumUgovora,
            this.CijenaAutomobila,
            this.UkupnaKolicina,
            this.Placanje});
            this.dgvUgovor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUgovor.Location = new System.Drawing.Point(3, 16);
            this.dgvUgovor.Name = "dgvUgovor";
            this.dgvUgovor.ReadOnly = true;
            this.dgvUgovor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovor.Size = new System.Drawing.Size(436, 302);
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
            // DatumUgovora
            // 
            this.DatumUgovora.DataPropertyName = "DatumUgovora";
            this.DatumUgovora.HeaderText = "Datum Ugovora";
            this.DatumUgovora.Name = "DatumUgovora";
            this.DatumUgovora.ReadOnly = true;
            // 
            // CijenaAutomobila
            // 
            this.CijenaAutomobila.DataPropertyName = "CijenaAutomobila";
            this.CijenaAutomobila.HeaderText = "Cijena Automobila";
            this.CijenaAutomobila.Name = "CijenaAutomobila";
            this.CijenaAutomobila.ReadOnly = true;
            // 
            // UkupnaKolicina
            // 
            this.UkupnaKolicina.DataPropertyName = "UkupnaKolicina";
            this.UkupnaKolicina.HeaderText = "UkupnaKolicina";
            this.UkupnaKolicina.Name = "UkupnaKolicina";
            this.UkupnaKolicina.ReadOnly = true;
            // 
            // Placanje
            // 
            this.Placanje.DataPropertyName = "NacinPlacanjaId";
            this.Placanje.HeaderText = "Placanje";
            this.Placanje.Name = "Placanje";
            this.Placanje.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(404, 0);
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
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUgovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUgovor";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUgovor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgovorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUgovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaAutomobila;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placanje;
    }
}