using Rent_A_Car.WinUI.Admin;
using Rent_A_Car.WinUI.Grad;
using Rent_A_Car.WinUI.Kategorija;
using Rent_A_Car.WinUI.Klijent;
using Rent_A_Car.WinUI.OcijenaIKomentar;
using Rent_A_Car.WinUI.Rezervacija;
using Rent_A_Car.WinUI.Ugovor;
using Rent_A_Car.WinUI.Vozilo;
using Rent_A_Car.WinUI.Zaposlenik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.WinUI
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
          

            frmZaposlenik frm = new frmZaposlenik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            frmKlijent frm = new frmKlijent();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {
            frmKategorija frm = new frmKategorija();
            frm.MdiParent = this;
            frm.Show();
        }

        private void brnGrad_Click(object sender, EventArgs e)
        {
            frmGrad frm = new frmGrad();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            frmPregledVozilo frm = new frmPregledVozilo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void brnUgovori_Click(object sender, EventArgs e)
        {
            frmUgovor frm = new frmUgovor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            frmRezervacija frm = new frmRezervacija();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOpcije_Click(object sender, EventArgs e)
        {
            //if(zaposlenik)
            frmAdminDetalji frm = new frmAdminDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormVerzija frm = new FormVerzija();
            frm.MdiParent = this;
            frm.Show();
        }

        private void brnOcjeneIKomentari_Click(object sender, EventArgs e)
        {
            frmOcijeniIKomentarisiPregled frm = new frmOcijeniIKomentarisiPregled();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
