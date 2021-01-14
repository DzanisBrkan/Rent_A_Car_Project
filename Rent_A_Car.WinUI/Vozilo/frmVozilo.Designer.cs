namespace Rent_A_Car.WinUI.Vozilo
{
    partial class frmVozilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVozilo));
            this.label1 = new System.Windows.Forms.Label();
            this.VoziloGrid = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.cmbSpecifikacija = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtRegistracijskiBroj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrSjedista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrojVrata = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtZprPrtljaznika = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOprema = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCijenaPoSatu = new System.Windows.Forms.TextBox();
            this.cbIznajmljeno = new System.Windows.Forms.CheckBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VoziloGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija";
            // 
            // VoziloGrid
            // 
            this.VoziloGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VoziloGrid.Location = new System.Drawing.Point(12, 376);
            this.VoziloGrid.Name = "VoziloGrid";
            this.VoziloGrid.Size = new System.Drawing.Size(776, 243);
            this.VoziloGrid.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(651, 71);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(131, 43);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Specifikacija vozila";
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(167, 36);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(148, 20);
            this.txtSlikaInput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Slika:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(167, 82);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 21);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(315, 170);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(190, 21);
            this.cmbKategorija.TabIndex = 11;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // cmbSpecifikacija
            // 
            this.cmbSpecifikacija.FormattingEnabled = true;
            this.cmbSpecifikacija.Location = new System.Drawing.Point(592, 170);
            this.cmbSpecifikacija.Name = "cmbSpecifikacija";
            this.cmbSpecifikacija.Size = new System.Drawing.Size(190, 21);
            this.cmbSpecifikacija.TabIndex = 12;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(114, 108);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // txtRegistracijskiBroj
            // 
            this.txtRegistracijskiBroj.Location = new System.Drawing.Point(64, 233);
            this.txtRegistracijskiBroj.Name = "txtRegistracijskiBroj";
            this.txtRegistracijskiBroj.Size = new System.Drawing.Size(190, 20);
            this.txtRegistracijskiBroj.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reg, Broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(315, 233);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(190, 20);
            this.txtModel.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(592, 233);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(190, 20);
            this.txtMarka.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Br. Sjedista";
            // 
            // txtBrSjedista
            // 
            this.txtBrSjedista.Location = new System.Drawing.Point(64, 270);
            this.txtBrSjedista.Name = "txtBrSjedista";
            this.txtBrSjedista.Size = new System.Drawing.Size(190, 20);
            this.txtBrSjedista.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Br. Vrata";
            // 
            // txtBrojVrata
            // 
            this.txtBrojVrata.Location = new System.Drawing.Point(315, 270);
            this.txtBrojVrata.Name = "txtBrojVrata";
            this.txtBrojVrata.Size = new System.Drawing.Size(190, 20);
            this.txtBrojVrata.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Zpr.Prtljaznika";
            // 
            // txtZprPrtljaznika
            // 
            this.txtZprPrtljaznika.Location = new System.Drawing.Point(592, 270);
            this.txtZprPrtljaznika.Name = "txtZprPrtljaznika";
            this.txtZprPrtljaznika.Size = new System.Drawing.Size(190, 20);
            this.txtZprPrtljaznika.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Oprema";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtOprema
            // 
            this.txtOprema.Location = new System.Drawing.Point(64, 310);
            this.txtOprema.Name = "txtOprema";
            this.txtOprema.Size = new System.Drawing.Size(190, 20);
            this.txtOprema.TabIndex = 26;
            this.txtOprema.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cijena/sat";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtCijenaPoSatu
            // 
            this.txtCijenaPoSatu.Location = new System.Drawing.Point(315, 310);
            this.txtCijenaPoSatu.Name = "txtCijenaPoSatu";
            this.txtCijenaPoSatu.Size = new System.Drawing.Size(190, 20);
            this.txtCijenaPoSatu.TabIndex = 28;
            this.txtCijenaPoSatu.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // cbIznajmljeno
            // 
            this.cbIznajmljeno.AutoSize = true;
            this.cbIznajmljeno.Location = new System.Drawing.Point(592, 312);
            this.cbIznajmljeno.Name = "cbIznajmljeno";
            this.cbIznajmljeno.Size = new System.Drawing.Size(78, 17);
            this.cbIznajmljeno.TabIndex = 32;
            this.cbIznajmljeno.Text = "Iznajmljeno";
            this.cbIznajmljeno.UseVisualStyleBackColor = true;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(64, 170);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(190, 21);
            this.cmbTip.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Tip vozila";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(735, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 35;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbIznajmljeno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCijenaPoSatu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOprema);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtZprPrtljaznika);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBrojVrata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBrSjedista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegistracijskiBroj);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cmbSpecifikacija);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.VoziloGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVozilo";
            this.Load += new System.EventHandler(this.frmVozilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VoziloGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VoziloGrid;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.ComboBox cmbSpecifikacija;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtRegistracijskiBroj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrSjedista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrojVrata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtZprPrtljaznika;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOprema;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCijenaPoSatu;
        private System.Windows.Forms.CheckBox cbIznajmljeno;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnExit;
    }
}