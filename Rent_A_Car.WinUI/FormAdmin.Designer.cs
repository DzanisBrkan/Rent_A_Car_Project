﻿namespace Rent_A_Car.WinUI
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLogiraniKorisnik = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnOpcije = new System.Windows.Forms.Button();
            this.brnOcjeneIKomentari = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.brnUgovori = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.brnGrad = new System.Windows.Forms.Button();
            this.btnKategorije = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.LeftPanel.Controls.Add(this.lblDobrodosli);
            this.LeftPanel.Controls.Add(this.panel2);
            this.LeftPanel.Controls.Add(this.btnHome);
            this.LeftPanel.Controls.Add(this.lbLogiraniKorisnik);
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Controls.Add(this.btnInfo);
            this.LeftPanel.Controls.Add(this.btnOdjava);
            this.LeftPanel.Controls.Add(this.btnOpcije);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(227, 733);
            this.LeftPanel.TabIndex = 0;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.ForeColor = System.Drawing.Color.White;
            this.lblDobrodosli.Location = new System.Drawing.Point(27, 252);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(171, 33);
            this.lblDobrodosli.TabIndex = 28;
            this.lblDobrodosli.Text = "Dobrodošli, ";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(23, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 69);
            this.panel2.TabIndex = 11;
            // 
            // lbLogiraniKorisnik
            // 
            this.lbLogiraniKorisnik.AutoSize = true;
            this.lbLogiraniKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogiraniKorisnik.ForeColor = System.Drawing.Color.White;
            this.lbLogiraniKorisnik.Location = new System.Drawing.Point(17, 299);
            this.lbLogiraniKorisnik.Name = "lbLogiraniKorisnik";
            this.lbLogiraniKorisnik.Size = new System.Drawing.Size(119, 33);
            this.lbLogiraniKorisnik.TabIndex = 27;
            this.lbLogiraniKorisnik.Text = "Logirani";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(81, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 69);
            this.panel1.TabIndex = 10;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(81, 653);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(48, 43);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Image = ((System.Drawing.Image)(resources.GetObject("btnOdjava.Image")));
            this.btnOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Location = new System.Drawing.Point(23, 573);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(186, 52);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "    Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnOpcije
            // 
            this.btnOpcije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcije.ForeColor = System.Drawing.Color.White;
            this.btnOpcije.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcije.Image")));
            this.btnOpcije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcije.Location = new System.Drawing.Point(23, 525);
            this.btnOpcije.Name = "btnOpcije";
            this.btnOpcije.Size = new System.Drawing.Size(186, 49);
            this.btnOpcije.TabIndex = 4;
            this.btnOpcije.Text = "Opcije       ";
            this.btnOpcije.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpcije.UseVisualStyleBackColor = true;
            this.btnOpcije.Click += new System.EventHandler(this.btnOpcije_Click);
            // 
            // brnOcjeneIKomentari
            // 
            this.brnOcjeneIKomentari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnOcjeneIKomentari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnOcjeneIKomentari.ForeColor = System.Drawing.Color.White;
            this.brnOcjeneIKomentari.Image = ((System.Drawing.Image)(resources.GetObject("brnOcjeneIKomentari.Image")));
            this.brnOcjeneIKomentari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnOcjeneIKomentari.Location = new System.Drawing.Point(621, 92);
            this.brnOcjeneIKomentari.Name = "brnOcjeneIKomentari";
            this.brnOcjeneIKomentari.Size = new System.Drawing.Size(216, 49);
            this.brnOcjeneIKomentari.TabIndex = 28;
            this.brnOcjeneIKomentari.Text = "Ocijene i komentari";
            this.brnOcjeneIKomentari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnOcjeneIKomentari.UseVisualStyleBackColor = true;
            this.brnOcjeneIKomentari.Click += new System.EventHandler(this.brnOcjeneIKomentari_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.ForeColor = System.Drawing.Color.White;
            this.btnRezervacije.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervacije.Image")));
            this.btnRezervacije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervacije.Location = new System.Drawing.Point(445, 92);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(170, 49);
            this.btnRezervacije.TabIndex = 15;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // brnUgovori
            // 
            this.brnUgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnUgovori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnUgovori.ForeColor = System.Drawing.Color.White;
            this.brnUgovori.Image = ((System.Drawing.Image)(resources.GetObject("brnUgovori.Image")));
            this.brnUgovori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnUgovori.Location = new System.Drawing.Point(311, 92);
            this.brnUgovori.Name = "brnUgovori";
            this.brnUgovori.Size = new System.Drawing.Size(128, 49);
            this.brnUgovori.TabIndex = 14;
            this.brnUgovori.Text = "Ugovori";
            this.brnUgovori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnUgovori.UseVisualStyleBackColor = true;
            this.brnUgovori.Click += new System.EventHandler(this.brnUgovori_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozila.ForeColor = System.Drawing.Color.White;
            this.btnVozila.Image = ((System.Drawing.Image)(resources.GetObject("btnVozila.Image")));
            this.btnVozila.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVozila.Location = new System.Drawing.Point(190, 91);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(115, 49);
            this.btnVozila.TabIndex = 13;
            this.btnVozila.Text = "Vozila";
            this.btnVozila.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlijenti.ForeColor = System.Drawing.Color.White;
            this.btnKlijenti.Image = ((System.Drawing.Image)(resources.GetObject("btnKlijenti.Image")));
            this.btnKlijenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlijenti.Location = new System.Drawing.Point(46, 91);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(138, 49);
            this.btnKlijenti.TabIndex = 12;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // brnGrad
            // 
            this.brnGrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGrad.ForeColor = System.Drawing.Color.White;
            this.brnGrad.Image = ((System.Drawing.Image)(resources.GetObject("brnGrad.Image")));
            this.brnGrad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnGrad.Location = new System.Drawing.Point(576, 36);
            this.brnGrad.Name = "brnGrad";
            this.brnGrad.Size = new System.Drawing.Size(117, 49);
            this.brnGrad.TabIndex = 3;
            this.brnGrad.Text = "Grad";
            this.brnGrad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnGrad.UseVisualStyleBackColor = true;
            this.brnGrad.Click += new System.EventHandler(this.brnGrad_Click);
            // 
            // btnKategorije
            // 
            this.btnKategorije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategorije.ForeColor = System.Drawing.Color.White;
            this.btnKategorije.Image = ((System.Drawing.Image)(resources.GetObject("btnKategorije.Image")));
            this.btnKategorije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategorije.Location = new System.Drawing.Point(400, 36);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Size = new System.Drawing.Size(164, 49);
            this.btnKategorije.TabIndex = 2;
            this.btnKategorije.Text = "Kategorije";
            this.btnKategorije.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategorije.UseVisualStyleBackColor = true;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposlenici.ForeColor = System.Drawing.Color.White;
            this.btnZaposlenici.Image = ((System.Drawing.Image)(resources.GetObject("btnZaposlenici.Image")));
            this.btnZaposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposlenici.Location = new System.Drawing.Point(228, 36);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(165, 49);
            this.btnZaposlenici.TabIndex = 1;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(23, 479);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "    Home ";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(917, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 42);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(970, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnZaposlenici);
            this.panel3.Controls.Add(this.brnOcjeneIKomentari);
            this.panel3.Controls.Add(this.brnGrad);
            this.panel3.Controls.Add(this.btnRezervacije);
            this.panel3.Controls.Add(this.btnKategorije);
            this.panel3.Controls.Add(this.brnUgovori);
            this.panel3.Controls.Add(this.btnKlijenti);
            this.panel3.Controls.Add(this.btnVozila);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 161);
            this.panel3.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LeftPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnOpcije;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLogiraniKorisnik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button brnOcjeneIKomentari;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnKlijenti;
        public System.Windows.Forms.Button brnGrad;
        public System.Windows.Forms.Button btnKategorije;
        public System.Windows.Forms.Button btnZaposlenici;
        public System.Windows.Forms.Button btnRezervacije;
        public System.Windows.Forms.Button brnUgovori;
        public System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Label lblDobrodosli;
    }
}

