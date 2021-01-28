namespace Rent_A_Car.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentiToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.vozilaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.dodajKlijentaToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // dodajKlijentaToolStripMenuItem
            // 
            this.dodajKlijentaToolStripMenuItem.Name = "dodajKlijentaToolStripMenuItem";
            this.dodajKlijentaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dodajKlijentaToolStripMenuItem.Text = "Dodaj Klijenta";
            this.dodajKlijentaToolStripMenuItem.Click += new System.EventHandler(this.dodajKlijentaToolStripMenuItem_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.dodajZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // dodajZaposlenikaToolStripMenuItem
            // 
            this.dodajZaposlenikaToolStripMenuItem.Name = "dodajZaposlenikaToolStripMenuItem";
            this.dodajZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajZaposlenikaToolStripMenuItem.Text = "Dodaj zaposlenika";
            this.dodajZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.dodajZaposlenikaToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaVozilaToolStripMenuItem});
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            // 
            // pretragaVozilaToolStripMenuItem
            // 
            this.pretragaVozilaToolStripMenuItem.Name = "pretragaVozilaToolStripMenuItem";
            this.pretragaVozilaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.pretragaVozilaToolStripMenuItem.Text = "Pretraga vozila";
            this.pretragaVozilaToolStripMenuItem.Click += new System.EventHandler(this.pretragaVozilaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajZaposlenikaToolStripMenuItem;
    }
}



