namespace Rent_A_Car.WinUI.Vozilo
{
    partial class frmPregledVozilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledVozilo));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBoxVozila = new System.Windows.Forms.GroupBox();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.VoziloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistracijskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZauzetoVozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojVrata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZapreminaPrtljaznika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaPoSatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKalendar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxVozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(797, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(19, 73);
            this.txtPretraga.Multiline = true;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(508, 43);
            this.txtPretraga.TabIndex = 15;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Location = new System.Drawing.Point(533, 73);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(102, 46);
            this.btnPrikazi.TabIndex = 14;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBoxVozila
            // 
            this.groupBoxVozila.Controls.Add(this.dgvKlijent);
            this.groupBoxVozila.Location = new System.Drawing.Point(12, 122);
            this.groupBoxVozila.Name = "groupBoxVozila";
            this.groupBoxVozila.Size = new System.Drawing.Size(849, 321);
            this.groupBoxVozila.TabIndex = 13;
            this.groupBoxVozila.TabStop = false;
            this.groupBoxVozila.Text = "Vozila";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.AllowUserToAddRows = false;
            this.dgvKlijent.AllowUserToDeleteRows = false;
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoziloID,
            this.RegistracijskiBroj,
            this.ZauzetoVozilo,
            this.Model,
            this.Marka,
            this.BrojSjedala,
            this.BrojVrata,
            this.ZapreminaPrtljaznika,
            this.CijenaPoSatu});
            this.dgvKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijent.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.ReadOnly = true;
            this.dgvKlijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijent.Size = new System.Drawing.Size(843, 302);
            this.dgvKlijent.TabIndex = 0;
            this.dgvKlijent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlijent_MouseDoubleClick);
            // 
            // VoziloID
            // 
            this.VoziloID.DataPropertyName = "VoziloID";
            this.VoziloID.HeaderText = "VoziloID";
            this.VoziloID.Name = "VoziloID";
            this.VoziloID.ReadOnly = true;
            this.VoziloID.Visible = false;
            // 
            // RegistracijskiBroj
            // 
            this.RegistracijskiBroj.DataPropertyName = "RegistracijskiBroj";
            this.RegistracijskiBroj.HeaderText = "RegistracijskiBroj";
            this.RegistracijskiBroj.Name = "RegistracijskiBroj";
            this.RegistracijskiBroj.ReadOnly = true;
            // 
            // ZauzetoVozilo
            // 
            this.ZauzetoVozilo.DataPropertyName = "Zauzeto";
            this.ZauzetoVozilo.HeaderText = "Zauzeto Vozilo";
            this.ZauzetoVozilo.Name = "ZauzetoVozilo";
            this.ZauzetoVozilo.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // BrojSjedala
            // 
            this.BrojSjedala.DataPropertyName = "BrSjedista";
            this.BrojSjedala.HeaderText = "BrojSjedala";
            this.BrojSjedala.Name = "BrojSjedala";
            this.BrojSjedala.ReadOnly = true;
            // 
            // BrojVrata
            // 
            this.BrojVrata.DataPropertyName = "BrVrata";
            this.BrojVrata.HeaderText = "BrojVrata";
            this.BrojVrata.Name = "BrojVrata";
            this.BrojVrata.ReadOnly = true;
            // 
            // ZapreminaPrtljaznika
            // 
            this.ZapreminaPrtljaznika.DataPropertyName = "ZapreminaPrtljaznika";
            this.ZapreminaPrtljaznika.HeaderText = "ZapreminaPrtljaznika";
            this.ZapreminaPrtljaznika.Name = "ZapreminaPrtljaznika";
            this.ZapreminaPrtljaznika.ReadOnly = true;
            // 
            // CijenaPoSatu
            // 
            this.CijenaPoSatu.DataPropertyName = "CijenaPoSatu";
            this.CijenaPoSatu.HeaderText = "CijenaPoSatu";
            this.CijenaPoSatu.Name = "CijenaPoSatu";
            this.CijenaPoSatu.ReadOnly = true;
            // 
            // btnKalendar
            // 
            this.btnKalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.btnKalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKalendar.ForeColor = System.Drawing.Color.White;
            this.btnKalendar.Location = new System.Drawing.Point(747, 73);
            this.btnKalendar.Name = "btnKalendar";
            this.btnKalendar.Size = new System.Drawing.Size(100, 46);
            this.btnKalendar.TabIndex = 17;
            this.btnKalendar.Text = "Kalendar";
            this.btnKalendar.UseVisualStyleBackColor = false;
            this.btnKalendar.Click += new System.EventHandler(this.btnKalendar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(641, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPregledVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKalendar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBoxVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregledVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledVozilo";
            this.Load += new System.EventHandler(this.frmPregledVozilo_Load);
            this.groupBoxVozila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBoxVozila;
        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoziloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistracijskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZauzetoVozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedala;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojVrata;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZapreminaPrtljaznika;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaPoSatu;
        private System.Windows.Forms.Button btnKalendar;
        private System.Windows.Forms.Button button1;
    }
}