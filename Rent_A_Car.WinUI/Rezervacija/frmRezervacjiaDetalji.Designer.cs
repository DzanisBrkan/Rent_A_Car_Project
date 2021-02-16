namespace Rent_A_Car.WinUI.Rezervacija
{
    partial class frmRezervacjiaDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacjiaDetalji));
            this.Rezervacija = new System.Windows.Forms.Label();
            this.KrajRezervacije = new System.Windows.Forms.Label();
            this.txtPocetak = new System.Windows.Forms.TextBox();
            this.Cijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.labelMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textKraj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Rezervacija
            // 
            this.Rezervacija.AutoSize = true;
            this.Rezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezervacija.Location = new System.Drawing.Point(120, 9);
            this.Rezervacija.Name = "Rezervacija";
            this.Rezervacija.Size = new System.Drawing.Size(200, 39);
            this.Rezervacija.TabIndex = 103;
            this.Rezervacija.Text = "Rezervacija";
            // 
            // KrajRezervacije
            // 
            this.KrajRezervacije.AutoSize = true;
            this.KrajRezervacije.Location = new System.Drawing.Point(37, 87);
            this.KrajRezervacije.Name = "KrajRezervacije";
            this.KrajRezervacije.Size = new System.Drawing.Size(106, 13);
            this.KrajRezervacije.TabIndex = 94;
            this.KrajRezervacije.Text = "Pocetak Rezervacije";
            // 
            // txtPocetak
            // 
            this.txtPocetak.Location = new System.Drawing.Point(143, 84);
            this.txtPocetak.Name = "txtPocetak";
            this.txtPocetak.Size = new System.Drawing.Size(265, 20);
            this.txtPocetak.TabIndex = 0;
            // 
            // Cijena
            // 
            this.Cijena.AutoSize = true;
            this.Cijena.Location = new System.Drawing.Point(45, 197);
            this.Cijena.Name = "Cijena";
            this.Cijena.Size = new System.Drawing.Size(36, 13);
            this.Cijena.TabIndex = 92;
            this.Cijena.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(143, 194);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(265, 20);
            this.txtCijena.TabIndex = 3;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(45, 155);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 90;
            this.Status.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(143, 152);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(265, 20);
            this.txtStatus.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(414, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(45, 233);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 108;
            this.labelModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(143, 230);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(265, 20);
            this.txtModel.TabIndex = 4;
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(45, 270);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(37, 13);
            this.labelMarka.TabIndex = 110;
            this.labelMarka.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(143, 267);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(265, 20);
            this.txtMarka.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Kraj Rezervacije";
            // 
            // textKraj
            // 
            this.textKraj.Location = new System.Drawing.Point(143, 119);
            this.textKraj.Name = "textKraj";
            this.textKraj.Size = new System.Drawing.Size(265, 20);
            this.textKraj.TabIndex = 1;
            // 
            // frmRezervacjiaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKraj);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Rezervacija);
            this.Controls.Add(this.KrajRezervacije);
            this.Controls.Add(this.txtPocetak);
            this.Controls.Add(this.Cijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.txtStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervacjiaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervacjiaDetalji";
            this.Load += new System.EventHandler(this.frmRezervacjiaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Rezervacija;
        private System.Windows.Forms.Label KrajRezervacije;
        private System.Windows.Forms.TextBox txtPocetak;
        private System.Windows.Forms.Label Cijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKraj;
    }
}