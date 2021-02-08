using Rent_A_Car.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.WinUI
{
    public partial class frmLocirajVoziloDetalji : Form
    {

        private readonly APIService _apiService = new APIService("Rezervacija");
        private readonly APIService _apiServiceVozilo = new APIService("Vozilo");
        private readonly APIService _lociranjaServices = new APIService("Lociranje");
        private int? _id = null;
        public frmLocirajVoziloDetalji(int? lociranjeid = null)
        {
            InitializeComponent();
            _id = lociranjeid;
        }

        public ObservableCollection<Model.Rezervacija> RezervacijaList { get; set; } = new ObservableCollection<Model.Rezervacija>();
        public ObservableCollection<Model.Rezervacija> PronadjeneRezervacijaList { get; set; } = new ObservableCollection<Model.Rezervacija>();

        public ObservableCollection<Model.Vozilo> VozilaList { get; set; } = new ObservableCollection<Model.Vozilo>();
        public ObservableCollection<Model.Vozilo> RezervisanaVozilaList { get; set; } = new ObservableCollection<Model.Vozilo>();


        public ObservableCollection<Lociranje> Lociranja { get; set; } = new ObservableCollection<Lociranje>();
        public ObservableCollection<Lociranje> PronadjenaLociranja { get; set; } = new ObservableCollection<Lociranje>();


        private async void frmLocirajVoziloDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var lociranje = await _apiService.GetById<Model.Lociranje>(_id);
                             

                if (lociranje.Prihvaceno == true)
                    txtPrihvaceno.Text = "DA";
                else
                    txtPrihvaceno.Text = "NE";

                if (lociranje.Odogovoreno == true)
                    txtOdgovoreno.Text = "DA";
                else
                    txtOdgovoreno.Text = "NE";

                txtKlijent.Text = lociranje.Klijent.Ime + " " + lociranje.Klijent.Prezime;
                txtZaposlenik.Text = lociranje.Zaposlenik.Ime + " " + lociranje.Zaposlenik.Prezime;
                txtVozilo.Text = lociranje.Vozilo.Marka + " ," + lociranje.Vozilo.Model;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
