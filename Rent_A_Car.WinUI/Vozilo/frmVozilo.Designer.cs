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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtCijenaPoSatu = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGodiste = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPotrosnja = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPogon = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtKilowataza = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtKubikaza = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEuroNorma = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGorivo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMjenjac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKonjaza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(515, 422);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(266, 47);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(21, 339);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(250, 20);
            this.txtSlikaInput.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodaj.Location = new System.Drawing.Point(21, 370);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(250, 35);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(408, 74);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(197, 21);
            this.cmbKategorija.TabIndex = 2;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(21, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 250);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // txtRegistracijskiBroj
            // 
            this.txtRegistracijskiBroj.Location = new System.Drawing.Point(409, 155);
            this.txtRegistracijskiBroj.Name = "txtRegistracijskiBroj";
            this.txtRegistracijskiBroj.Size = new System.Drawing.Size(196, 20);
            this.txtRegistracijskiBroj.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reg, Broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(408, 191);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(196, 20);
            this.txtModel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(408, 230);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(196, 20);
            this.txtMarka.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Br. Sjedista";
            // 
            // txtBrSjedista
            // 
            this.txtBrSjedista.Location = new System.Drawing.Point(408, 269);
            this.txtBrSjedista.Name = "txtBrSjedista";
            this.txtBrSjedista.Size = new System.Drawing.Size(196, 20);
            this.txtBrSjedista.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Br. Vrata";
            // 
            // txtBrojVrata
            // 
            this.txtBrojVrata.Location = new System.Drawing.Point(408, 306);
            this.txtBrojVrata.Name = "txtBrojVrata";
            this.txtBrojVrata.Size = new System.Drawing.Size(196, 20);
            this.txtBrojVrata.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Zpr.Prtljaznika";
            // 
            // txtZprPrtljaznika
            // 
            this.txtZprPrtljaznika.Location = new System.Drawing.Point(408, 343);
            this.txtZprPrtljaznika.Name = "txtZprPrtljaznika";
            this.txtZprPrtljaznika.Size = new System.Drawing.Size(196, 20);
            this.txtZprPrtljaznika.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cijena/sat";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtCijenaPoSatu
            // 
            this.txtCijenaPoSatu.Location = new System.Drawing.Point(408, 379);
            this.txtCijenaPoSatu.Name = "txtCijenaPoSatu";
            this.txtCijenaPoSatu.Size = new System.Drawing.Size(196, 20);
            this.txtCijenaPoSatu.TabIndex = 10;
            this.txtCijenaPoSatu.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(409, 110);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(196, 21);
            this.cmbTip.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(325, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Tip vozila";
            this.label12.Click += new System.EventHandler(this.label12_Click);
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
            this.btnExit.Location = new System.Drawing.Point(904, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 21;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(635, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(5, 326);
            this.label10.TabIndex = 36;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(303, 25);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(66, 23);
            this.lblNaslov.TabIndex = 37;
            this.lblNaslov.Text = "Vozilo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(682, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 51;
            this.label14.Text = "Godište";
            // 
            // txtGodiste
            // 
            this.txtGodiste.Location = new System.Drawing.Point(755, 340);
            this.txtGodiste.Name = "txtGodiste";
            this.txtGodiste.Size = new System.Drawing.Size(196, 20);
            this.txtGodiste.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(674, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "Potrošnja";
            // 
            // txtPotrosnja
            // 
            this.txtPotrosnja.Location = new System.Drawing.Point(755, 303);
            this.txtPotrosnja.Name = "txtPotrosnja";
            this.txtPotrosnja.Size = new System.Drawing.Size(196, 20);
            this.txtPotrosnja.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(682, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 47;
            this.label16.Text = "Pogon";
            // 
            // txtPogon
            // 
            this.txtPogon.Location = new System.Drawing.Point(755, 263);
            this.txtPogon.Name = "txtPogon";
            this.txtPogon.Size = new System.Drawing.Size(196, 20);
            this.txtPogon.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(662, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "Kilowataža";
            // 
            // txtKilowataza
            // 
            this.txtKilowataza.Location = new System.Drawing.Point(755, 224);
            this.txtKilowataza.Name = "txtKilowataza";
            this.txtKilowataza.Size = new System.Drawing.Size(196, 20);
            this.txtKilowataza.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(666, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "Kubikaža";
            // 
            // txtKubikaza
            // 
            this.txtKubikaza.Location = new System.Drawing.Point(755, 152);
            this.txtKubikaza.Name = "txtKubikaza";
            this.txtKubikaza.Size = new System.Drawing.Size(196, 20);
            this.txtKubikaza.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(660, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 16);
            this.label19.TabIndex = 41;
            this.label19.Text = "Euro norma";
            // 
            // txtEuroNorma
            // 
            this.txtEuroNorma.Location = new System.Drawing.Point(755, 109);
            this.txtEuroNorma.Name = "txtEuroNorma";
            this.txtEuroNorma.Size = new System.Drawing.Size(196, 20);
            this.txtEuroNorma.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(679, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "Gorivo";
            // 
            // txtGorivo
            // 
            this.txtGorivo.Location = new System.Drawing.Point(755, 73);
            this.txtGorivo.Name = "txtGorivo";
            this.txtGorivo.Size = new System.Drawing.Size(196, 20);
            this.txtGorivo.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(631, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 23);
            this.label21.TabIndex = 52;
            this.label21.Text = "Specifikacije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mjenjač";
            // 
            // txtMjenjac
            // 
            this.txtMjenjac.Location = new System.Drawing.Point(755, 377);
            this.txtMjenjac.Name = "txtMjenjac";
            this.txtMjenjac.Size = new System.Drawing.Size(196, 20);
            this.txtMjenjac.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Konjaža";
            // 
            // txtKonjaza
            // 
            this.txtKonjaza.Location = new System.Drawing.Point(755, 188);
            this.txtKonjaza.Name = "txtKonjaza";
            this.txtKonjaza.Size = new System.Drawing.Size(196, 20);
            this.txtKonjaza.TabIndex = 14;
            // 
            // frmVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKonjaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMjenjac);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtGodiste);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPotrosnja);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPogon);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtKilowataza);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtKubikaza);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtEuroNorma);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtGorivo);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCijenaPoSatu);
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
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVozilo";
            this.Load += new System.EventHandler(this.frmVozilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbKategorija;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCijenaPoSatu;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGodiste;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPotrosnja;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPogon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtKilowataza;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtKubikaza;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEuroNorma;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtGorivo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMjenjac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKonjaza;
    }
}