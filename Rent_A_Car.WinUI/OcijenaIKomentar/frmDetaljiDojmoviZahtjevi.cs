using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.WinUI.OcijenaIKomentar
{
    public partial class frmDetaljiDojmoviZahtjevi : Form
    {
        private readonly APIService _services = new APIService("Ocjena");
        private readonly APIService _servicesZAPOSLENIK = new APIService("Zaposlenik");
        private readonly APIService _servicesVozilo = new APIService("Vozilo");
        private readonly APIService _servicesUgovor = new APIService("Ugovor");
        private readonly APIService _servicesRezervacija = new APIService("Rezervacija");
        private readonly APIService _servicesDojam = new APIService("DojmoviZahtjevi");

        private int? _id = null;

        public frmDetaljiDojmoviZahtjevi(int? dojamId = null)
        {
            InitializeComponent();
            _id = dojamId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmDetaljiDojmoviZahtjevi_Load(object sender, EventArgs e)
        {
            try
            {
                if (_id.HasValue)
                {
                    //var ocjena = await _services.GetById<Model.Ocjena>(_id);

                    //var rezervacija = await _servicesRezervacija.GetById<Model.Rezervacija>(ocjena.RezervacijaId);

                    //var vozilo = await _servicesVozilo.GetById<Model.Vozilo>(ocjena.VoziloId);
                    var dojam = await _servicesDojam.GetById<Model.DojmoviZahtjevi>(_id);

                    var zaposlenik = await _servicesZAPOSLENIK.GetById<Model.Zaposlenik>(dojam.ZaposlenikId);



                    txtKlijent.Text = dojam.KlijentKorisnickoIme;
                    txtKlijent.ReadOnly = true;

                    txtNazivZahtjeva.Text = dojam.NazivZahtjeva;
                    txtNazivZahtjeva.ReadOnly = true;

                    txtDojam.Text = dojam.Dojam;
                    txtDojam.ReadOnly = true;

                    if (dojam.Odgovor != null)
                        txtOdgovor.Text = dojam.Odgovor;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske!");
                throw;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                var dojam = await _servicesDojam.GetById<Model.DojmoviZahtjevi>(_id);

                //txtZaposlenik.Text,


                if (this.ValidateChildren())// sprijeciti korisnika da klikne dugme snimi bez ikakvih validacija
                {
                    var request = new DojmoviZahtjeviUpsertRequest()
                    {
                        KlijentKorisnickoIme = txtKlijent.Text,
                        NazivZahtjeva = txtNazivZahtjeva.Text,
                        Dojam = txtDojam.Text,
                        Odgovor = txtOdgovor.Text,
                        ZaposlenikId = dojam.ZaposlenikId,
                        KlijentId = dojam.KlijentId,
                        RezervacijaId = dojam.RezervacijaId

                };

                    // ako je id popunje radimo update

                    if (_id.HasValue)
                    {
                        await _servicesDojam.Update<Model.DojmoviZahtjevi>(_id, request);
                    }
                    else
                    {
                        await _servicesDojam.Insert<Model.DojmoviZahtjevi>(request);
                    }

                    MessageBox.Show("Uspjesno ste odgovorili na zahtjev!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Doslo je do greske!");
            }
        }
    }
}
