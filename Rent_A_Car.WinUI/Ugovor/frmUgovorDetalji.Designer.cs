﻿namespace Rent_A_Car.WinUI.Ugovor
{
    partial class frmUgovorDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUgovorDetalji));
            this.Ugovor = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.Placen = new System.Windows.Forms.Label();
            this.UkupnaKolicina = new System.Windows.Forms.Label();
            this.txtUkupnaKolicina = new System.Windows.Forms.TextBox();
            this.UkupnaCijena = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.cbPlacen = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ugovor
            // 
            this.Ugovor.AutoSize = true;
            this.Ugovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ugovor.Location = new System.Drawing.Point(175, 25);
            this.Ugovor.Name = "Ugovor";
            this.Ugovor.Size = new System.Drawing.Size(129, 39);
            this.Ugovor.TabIndex = 103;
            this.Ugovor.Text = "Ugovor";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(38, 103);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 94;
            this.Datum.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(136, 100);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(265, 20);
            this.txtDatum.TabIndex = 93;
            // 
            // Placen
            // 
            this.Placen.AutoSize = true;
            this.Placen.Location = new System.Drawing.Point(38, 223);
            this.Placen.Name = "Placen";
            this.Placen.Size = new System.Drawing.Size(40, 13);
            this.Placen.TabIndex = 90;
            this.Placen.Text = "Placen";
            // 
            // UkupnaKolicina
            // 
            this.UkupnaKolicina.AutoSize = true;
            this.UkupnaKolicina.Location = new System.Drawing.Point(38, 180);
            this.UkupnaKolicina.Name = "UkupnaKolicina";
            this.UkupnaKolicina.Size = new System.Drawing.Size(85, 13);
            this.UkupnaKolicina.TabIndex = 88;
            this.UkupnaKolicina.Text = "Ukupna Kolicina";
            // 
            // txtUkupnaKolicina
            // 
            this.txtUkupnaKolicina.Location = new System.Drawing.Point(136, 177);
            this.txtUkupnaKolicina.Name = "txtUkupnaKolicina";
            this.txtUkupnaKolicina.Size = new System.Drawing.Size(265, 20);
            this.txtUkupnaKolicina.TabIndex = 87;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSize = true;
            this.UkupnaCijena.Location = new System.Drawing.Point(38, 142);
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.Size = new System.Drawing.Size(77, 13);
            this.UkupnaCijena.TabIndex = 86;
            this.UkupnaCijena.Text = "Ukupna Cijena";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(136, 139);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(265, 20);
            this.txtUkupnaCijena.TabIndex = 85;
            // 
            // cbPlacen
            // 
            this.cbPlacen.AutoSize = true;
            this.cbPlacen.Location = new System.Drawing.Point(244, 223);
            this.cbPlacen.Name = "cbPlacen";
            this.cbPlacen.Size = new System.Drawing.Size(15, 14);
            this.cbPlacen.TabIndex = 106;
            this.cbPlacen.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(410, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 107;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUgovorDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 278);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbPlacen);
            this.Controls.Add(this.Ugovor);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.Placen);
            this.Controls.Add(this.UkupnaKolicina);
            this.Controls.Add(this.txtUkupnaKolicina);
            this.Controls.Add(this.UkupnaCijena);
            this.Controls.Add(this.txtUkupnaCijena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUgovorDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUgovorDetalji";
            this.Load += new System.EventHandler(this.frmUgovorDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Ugovor;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label Placen;
        private System.Windows.Forms.Label UkupnaKolicina;
        private System.Windows.Forms.TextBox txtUkupnaKolicina;
        private System.Windows.Forms.Label UkupnaCijena;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.CheckBox cbPlacen;
        private System.Windows.Forms.Button btnExit;
    }
}