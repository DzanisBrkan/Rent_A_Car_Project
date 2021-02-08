using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
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
    public partial class frmLocirajVozilo : Form
    {
        //komitanje
        private readonly APIService _apiService = new APIService("Rezervacija");
        private readonly APIService _apiServiceVozilo = new APIService("Vozilo");
        private readonly APIService _lociranjaServices = new APIService("Lociranje");
        public frmLocirajVozilo()
        {
            InitializeComponent();
        }

        //public Model.Voznje Voznja { get; set; }
        public ObservableCollection<Model.Rezervacija> RezervacijaList { get; set; } = new ObservableCollection<Model.Rezervacija>();
        public ObservableCollection<Model.Rezervacija> PronadjeneRezervacijaList { get; set; } = new ObservableCollection<Model.Rezervacija>();

        public ObservableCollection<Model.Vozilo> VozilaList { get; set; } = new ObservableCollection<Model.Vozilo>();
        public ObservableCollection<Model.Vozilo> RezervisanaVozilaList { get; set; } = new ObservableCollection<Model.Vozilo>();


        public ObservableCollection<Lociranje> Lociranja { get; set; } = new ObservableCollection<Lociranje>();
        public ObservableCollection<Lociranje> PronadjenaLociranja { get; set; } = new ObservableCollection<Lociranje>();

        private Model.Lociranje _lociranja;
        public Model.Lociranje Lociranje;
        public Model.Vozilo Vozilo { get; set; }

        public async Task PrikazLokacijaPoVoziluKojiJeUToku()
        {

            //var result = await _apiService.Get<List<Model.Rezervacija>>(null);

            //RezervacijaList.Clear();
            //foreach (var rez in result)
            //{
            //    RezervacijaList.Add(rez);
            //}

            //PronadjeneRezervacijaList.Clear();
            //for (int i = 0; i < RezervacijaList.Count; i++)
            //{
            //    if (RezervacijaList[i].Status == "U toku")
            //    {
            //        PronadjeneRezervacijaList.Add(RezervacijaList[i]);
            //    }
            //}


            ////---------------------VOZILO-------------------------------------------------------------------------

            //var vozila = await _apiServiceVozilo.Get<List<Model.Vozilo>>(null);


            //VozilaList.Clear();
            //foreach (var voz in vozila)
            //{
            //    VozilaList.Add(voz);
            //}

            //RezervisanaVozilaList.Clear();
            //for (int i = 0; i < VozilaList.Count; i++)
            //{
            //    for (int j = 0; j < PronadjeneRezervacijaList.Count; j++)
            //    {
            //        if (VozilaList[i].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
            //        {
            //            RezervisanaVozilaList.Add(VozilaList[i]);
            //        }
            //    }

            //}



            ////-------------------------LOCIRANJA------------------------------------------------------------------------------


            //var lociranjaList = await _lociranjaServices.Get<IEnumerable<Model.Lociranje>>(null);
            //foreach (var lok in lociranjaList)
            //{
            //    //if (lok.VoziloId == Voznja.VoznjaId)
            //    //Lociranje = lok;
            //    Lociranja.Add(lok);
            //}


            //for (int i = 0; i < Lociranja.Count(); i++)
            //{
            //    for (int j = 0; j < RezervisanaVozilaList.Count(); j++)
            //    {
            //        if (Lociranja[i].VoziloId == RezervisanaVozilaList[j].VoziloID)
            //        {
            //            PronadjenaLociranja[i] = Lociranja[i];
            //        }
            //    }
            //}


        
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnVozila_Click(object sender, EventArgs e)
        {
            //await model.InitDodajZahtjev();
            MessageBox.Show("Zahtjev za lokacijom poslat!");
            //map.IsVisible = false;
            //labela.Text = "Vozač jos uvijek nije prihvatio zahtjev!";
            //Lociraj.IsVisible = false;




            //public async Task InitDodajZahtjev()
            var request = new LociranjeUpsertRequest()
            {
                //KlijentId = APIService.LogovaniKlijent.KlijentId,
                ZaposlenikId = null,
                Lat = "string",
                Lng = "string",
                Odogovoreno = false,
                Prihvaceno = false,
                //VoziloId = Voznja.VoznjaId


            };



            await _lociranjaServices.Insert<Model.Lociranje>(request);
            MessageBox.Show("Zahtjev za lociranjem je poslat!");



            //public void Lociranje()


            //if (Model.Lociranje == null)
            //{
            //    map.IsVisible = false;
            //    labela.Text = "Želite locirati vozača?";
            //    Lociraj.IsVisible = true;
            //}
            //else if (model.Lociranje.Odogovoreno == true && model.Lociranje.Prihvaceno == true && model.Lociranje.KlijentId != null)
            //{
            //    double lat = 0;
            //    double longt = 0;

            //    Lociraj.IsVisible = true;
            //    lat = /*Convert.ToDouble(loc.Lat);*/double.Parse(model.Lociranje.Lat.Replace(',', '.'), CultureInfo.InvariantCulture);
            //    longt = /*Convert.ToDouble(loc.Lng);*/double.Parse(model.Lociranje.Lng.Replace(',', '.'), CultureInfo.InvariantCulture);

            //    Pin lokacija = new Pin()
            //    {

            //        Position = new Position(lat, longt),
            //        Label = "Lokacija vozača",
            //        Type = PinType.Generic
            //    };

            //    map.Pins.Add(lokacija);

            //    Position pozicija = new Position(lat, longt);
            //    map.MoveToRegion(new MapSpan(pozicija, 0.1, 0.1));
            //}
            //else if (model.Lociranje.Odogovoreno == true && model.Lociranje.Prihvaceno == false && model.Lociranje.KlijentId != null)
            //{
            //    map.IsVisible = false;
            //    Lociraj.IsVisible = true;
            //    labela.Text = "Vaš posljednji zahtjev je odbijen!\n \nKlikni na lociraj za ponovno slanje";
            //    Application.Current.MainPage.DisplayAlert("Obavjest!", "Vozač je odbio vas zadnji posalni zahtjev!", "OK");
            //}
            //else if (model.Lociranje.Odogovoreno == false && model.Lociranje.Prihvaceno == false && model.Lociranje.KlijentId != null)
            //{
            //    map.IsVisible = false;
            //    labela.Text = "Vozač jos uvijek nije prihvatio zahtjev!";
            //    Lociraj.IsVisible = false;
            //    Application.Current.MainPage.DisplayAlert("Obavjest!", "Na poslani zahtjev jos nije odgovoreno!", "OK");
            //}


        }
    }
}
