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
    
    public partial class frmOcjenaDetalji : Form
    {
        private readonly APIService _services = new APIService("Ocjena");
        private readonly APIService _servicesVozilo = new APIService("Vozilo");
        private readonly APIService _servicesUgovor = new APIService("Ugovor");
        private readonly APIService _servicesRezervacija = new APIService("Rezervacija");
        private int? _id = null;
        public frmOcjenaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmOcjenaDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_id.HasValue)
                {
                    var ocjena = await _services.GetById<Model.Ocjena>(_id);

                    var rezervacija = await _servicesRezervacija.GetById<Model.Rezervacija>(ocjena.RezervacijaId);

                    var vozilo = await _servicesVozilo.GetById<Model.Vozilo>(rezervacija.VoziloId);

                    var Racun = await _servicesUgovor.GetById<Model.Ugovor>(rezervacija.RacunId);


                    txtOcjena.Text = ocjena.Ocjena1.ToString();
                    txtKomentar.Text = ocjena.Komentar;
                    txtDatumRacuna.Text = Racun.Datum.ToString();
                    txtModel.Text = vozilo.Model;
                    txtMarkaa.Text = vozilo.Marka.ToString();
                    txtCijena.Text = rezervacija.Cijena.ToString();
                    txtStatus.Text = rezervacija.Status;
                    if (Racun.Placen == 1)
                    {
                        checkBoxPlacen.Checked = true;
                    }
                    else
                    {
                        checkBoxPlacen.Checked = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske!");
                throw;
            }
        }

        private void placenlabela_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPlacen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
