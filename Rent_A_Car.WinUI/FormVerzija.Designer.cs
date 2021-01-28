namespace Rent_A_Car.WinUI
{
    partial class FormVerzija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerzija));
            this.labelVerzija = new System.Windows.Forms.Label();
            this.txtNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVerzija
            // 
            this.labelVerzija.AutoSize = true;
            this.labelVerzija.BackColor = System.Drawing.Color.White;
            this.labelVerzija.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerzija.ForeColor = System.Drawing.Color.Red;
            this.labelVerzija.Location = new System.Drawing.Point(57, 215);
            this.labelVerzija.Name = "labelVerzija";
            this.labelVerzija.Size = new System.Drawing.Size(651, 55);
            this.labelVerzija.TabIndex = 0;
            this.labelVerzija.Text = "Verzija aplikacije: 2.2.2 (beta)";
            // 
            // txtNazad
            // 
            this.txtNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazad.ForeColor = System.Drawing.Color.White;
            this.txtNazad.Location = new System.Drawing.Point(748, 12);
            this.txtNazad.Name = "txtNazad";
            this.txtNazad.Size = new System.Drawing.Size(40, 40);
            this.txtNazad.TabIndex = 83;
            this.txtNazad.Text = "X";
            this.txtNazad.UseVisualStyleBackColor = false;
            this.txtNazad.Click += new System.EventHandler(this.txtNazad_Click);
            // 
            // FormVerzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNazad);
            this.Controls.Add(this.labelVerzija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerzija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVerzija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVerzija;
        private System.Windows.Forms.Button txtNazad;
    }
}