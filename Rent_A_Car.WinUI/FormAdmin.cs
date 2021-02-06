﻿using Rent_A_Car.WinUI.Admin;
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
        private readonly APIService _servicesZaposlenik = new APIService("Zaposlenik");
        private readonly APIService _servicesKlijent = new APIService("Klijent");
        private int? _id = null;
        public FormAdmin(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;

            

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


        private  void btnKlijenti_Click(object sender, EventArgs e)
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
            var id = _id;
            //var id = btnOpcije.SelectedRows[0].Cells[0].Value;

            frmAdminDetalji frm = new frmAdminDetalji(int.Parse(id.ToString()));
            frm.Show();


            //frmAdminDetalji frm = new frmAdminDetalji();
            //frm.MdiParent = this;
            //frm.Show();
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

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();
            //frm.MdiParent = this;
            //frm.Show();
            this.Close();
        }

        private async void FormAdmin_Load(object sender, EventArgs e)
        {

            btnKlijenti.Visible = false;
            brnOcjeneIKomentari.Visible = false;
            btnRezervacije.Visible = false;
            btnVozila.Visible = false;
            brnUgovori.Visible = false;
            btnZaposlenici.Visible = false;
            btnKategorije.Visible = false;
            brnGrad.Visible = false;


            //var KlijentModel = await _servicesKlijent.GetById<Model.Klijent>(_id);
            //var ZaposleniktModel = await _servicesZaposlenik.GetById<Model.Zaposlenik>(_id);

            //var LogovaniKlijent = false;
            //var LogovaniZaposlenik = false;

            //if (KlijentModel != null)
            //    LogovaniKlijent = true;

            //if (ZaposleniktModel != null)
            //    LogovaniZaposlenik = true;

            //if (LogovaniKlijent)
            //{
            //    btnKlijenti.Visible = true;
            //    brnOcjeneIKomentari.Visible = true;
            //    btnRezervacije.Visible = true;
            //    btnVozila.Visible = true;
            //    brnUgovori.Visible = true;
            //}

            //if (LogovaniZaposlenik)
            //{
            //    btnZaposlenici.Visible = true;
            //    btnKategorije.Visible = true;
            //    brnGrad.Visible = true;


            //}

            //var KlijentModel = await _servicesKlijent.GetById<Model.Klijent>(_id);
            var ZaposleniktModel = await _servicesZaposlenik.GetById<Model.Zaposlenik>(_id);

            var LogovaniAdmin = false;
            var LogovaniZaposlenik = false;

            if (LogovaniAdmin != null)
            {
                if (ZaposleniktModel.KorisnickiNalog.KorisnickiNalogId == 1)
                {
                    LogovaniAdmin = true;
                    lbLogiraniKorisnik.Text = ZaposleniktModel.KorisnickoIme;
                }
                else if (ZaposleniktModel.KorisnickiNalog.KorisnickiNalogId == 2)
                {
                    LogovaniZaposlenik = true;
                    lbLogiraniKorisnik.Text = ZaposleniktModel.KorisnickoIme;
                }
            }

            if (LogovaniZaposlenik)
            {
                //btnKlijenti.Enabled = false;
                //brnOcjeneIKomentari.Enabled = false;
                //btnRezervacije.Enabled = false;
                //btnVozila.Enabled = false;

                btnKlijenti.Visible = true;
                brnOcjeneIKomentari.Visible = true;
                btnRezervacije.Visible = true;
                btnVozila.Visible = true;
                brnUgovori.Visible = true;
            }

            if (LogovaniAdmin)
            {
                //btnZaposlenici.Enabled = false;
                //btnKategorije.Enabled = false;
                //brnGrad.Enabled = false;

                btnZaposlenici.Visible = true;
                btnKategorije.Visible = true;
                brnGrad.Visible = true;

            }
        }
    }
}
