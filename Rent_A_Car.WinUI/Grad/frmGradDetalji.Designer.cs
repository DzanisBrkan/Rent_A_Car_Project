﻿namespace Rent_A_Car.WinUI.Grad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradDetalji));
            this.btnSnimi = new System.Windows.Forms.Button();
            this.Grada = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.PostanskiBroj = new System.Windows.Forms.Label();
            this.txtPostanskiBroj = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(177, 181);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(138, 57);
            this.btnSnimi.TabIndex = 2;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
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
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(149, 88);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
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
            // txtPostanskiBroj
            // 
            this.txtPostanskiBroj.Location = new System.Drawing.Point(149, 127);
            this.txtPostanskiBroj.Name = "txtPostanskiBroj";
            this.txtPostanskiBroj.Size = new System.Drawing.Size(265, 20);
            this.txtPostanskiBroj.TabIndex = 1;
            this.txtPostanskiBroj.Validating += new System.ComponentModel.CancelEventHandler(this.txtPostanskiBroj_Validating);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(441, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmGradDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.Grada);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.PostanskiBroj);
            this.Controls.Add(this.txtPostanskiBroj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGradDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGradDetalji";
            this.Load += new System.EventHandler(this.frmGradDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label Grada;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label PostanskiBroj;
        private System.Windows.Forms.TextBox txtPostanskiBroj;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}