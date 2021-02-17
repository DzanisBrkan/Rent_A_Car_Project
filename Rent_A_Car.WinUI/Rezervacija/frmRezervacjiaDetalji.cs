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

namespace Rent_A_Car.WinUI.Rezervacija
{
    public partial class frmRezervacjiaDetalji : Form
    {
        private readonly APIService _services = new APIService("Rezervacija");
        private readonly APIService _servicesVozilo = new APIService("Vozilo");
        private readonly APIService _servicesKlijent = new APIService("Klijent");
        private int? _id = null;
        public frmRezervacjiaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void frmRezervacjiaDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_id.HasValue)
                {
                
                    var rezervacija = await _services.GetById<Model.Rezervacija>(_id);
                    
                    var klijent = await _servicesKlijent.GetById<Model.Klijent>(rezervacija.KlijentId);
                    
                    var request = new VoziloSearchRequest()
                    {
                        VoziloId = rezervacija.VoziloId
                    };

                    var vozilo = await _servicesVozilo.GetById<Model.Vozilo>(rezervacija.VoziloId);

                    txtPocetak.Text = rezervacija.PocetakRezervacije.ToString();
                    txtPocetak.ReadOnly = true;
                    textKraj.Text = rezervacija.KrajRezervacije.ToString();
                    textKraj.ReadOnly = true;

                    txtStatus.Text = rezervacija.Status;
                    txtStatus.ReadOnly = true;

                    //txtCijena.Text = rezervacija.UkupnaCijena.ToString();
                    txtModel.Text = vozilo.Model;
                    txtModel.ReadOnly = true;

                    txtMarka.Text = vozilo.Marka;
                    txtMarka.ReadOnly = true;

                    txtCijena.Text = vozilo.CijenaPoSatu.ToString();
                    txtCijena.ReadOnly = true;


                    textKlijent.Text = klijent.Ime + " " + klijent.Prezime;
                    textKlijent.ReadOnly = true;

                    txtNazivRezervacije.Text = rezervacija.Naziv;
                    txtNazivRezervacije.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške!");
                throw;
            }
        }
    }
}
