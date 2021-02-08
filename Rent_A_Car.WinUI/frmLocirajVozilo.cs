using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms.Maps;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace Rent_A_Car.WinUI
{
    public partial class frmLocirajVozilo : Form
    {
        //komitanje
        private readonly APIService _apiService = new APIService("Rezervacija");
        private readonly APIService _apiServiceVozilo = new APIService("Vozilo");
        private readonly APIService _lociranjaServices = new APIService("Lociranje");
        private int? _id = null;
        public frmLocirajVozilo(int? voziloId = null)
        {
            InitializeComponent();
            _id = voziloId;

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

            var vozilo = await _apiServiceVozilo.GetById<Model.Vozilo>(_id);

            //MessageBox.Show("Zahtjev za lokacijom poslat!");

            //if (this.ValidateChildren())// sprijeciti korisnika da klikne dugme snimi bez ikakvih validacija
            //{
            //    var requestt = new LociranjeUpsertRequest()
            //    {
            //        KlijentId = lociranje.KlijentId,
            //        ZaposlenikId = null,
            //        Lat = vozilo.Langitude.ToString(),
            //        Lng = vozilo.Longitude.ToString(),
            //        Odogovoreno = false,
            //        Prihvaceno = false,
            //        VoziloId = (int)lociranje.VoziloId
            //    };


            //await _lociranjaServices.Insert<Model.Lociranje>(requestt);
            //MessageBox.Show("Zahtjev za lociranjem je poslat!");


            //}

            //=-=================================== video=================================================

            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;

            //double laat = Convert.ToDouble(txtKlijent.Text);
            //double lon = Convert.ToDouble(txtVozilo.Text);

            double laat = (double)vozilo.Langitude;
            double lon = (double)vozilo.Longitude;


            map.Position = new PointLatLng(laat, lon);

            map.MinZoom = 1;
            map.MaxZoom = 100;
            map.Zoom = 10;

            //=-=================================== video=================================================


            //public void Lociranje()


            //    if (lociranje == null)
            //    {
            //        //map.IsVisible = false;
            //        labela.Text = "Želite locirati vozača?";
            //        //Lociraj.IsVisible = true;
            //    }
            //    else if (lociranje.Odogovoreno == true && lociranje.Prihvaceno == true && lociranje.KlijentId != null)
            //    {
            //        double lat = 0;
            //        double longt = 0;

            //        //Lociraj.IsVisible = true;
            //        lat = /*Convert.ToDouble(loc.Lat);*/double.Parse(lociranje.Lat.Replace(',', '.'), CultureInfo.InvariantCulture);
            //        longt = /*Convert.ToDouble(loc.Lng);*/double.Parse(lociranje.Lng.Replace(',', '.'), CultureInfo.InvariantCulture);

            //        Pin lokacija = new Pin()
            //        {

            //            Position = new Position(lat, longt),
            //            Label = "Lokacija vozača",
            //            Type = PinType.Generic
            //        };

            //        map.Pins.Add(lokacija);

            //        Position pozicija = new Position(lat, longt);
            //        map.MoveToRegion(new MapSpan(pozicija, 0.1, 0.1));
            //    }
            //    else if (lociranje.Odogovoreno == true && lociranje.Prihvaceno == false && lociranje.KlijentId != null)
            //    {
            //        //map.IsVisible = false;
            //        //Lociraj.IsVisible = true;
            //        MessageBox.Show("Vaš posljednji zahtjev je odbijen!\n \nKlikni na lociraj za ponovno slanje");
            //        MessageBox.Show("Vozač je odbio vas zadnji posalni zahtjev!");
            //    }
            //    else if (lociranje.Odogovoreno == false && lociranje.Prihvaceno == false && lociranje.KlijentId != null)
            //    {
            //        //map.IsVisible = false;
            //        labela.Text = "Vozač jos uvijek nije prihvatio zahtjev!";
            //        //Lociraj.IsVisible = false;
            //        MessageBox.Show("Na poslani zahtjev jos nije odgovoreno!");
            //    }


            //}


        }

        private async void frmLocirajVozilo_Load(object sender, EventArgs e)
        {
            var vozilo = await _apiServiceVozilo.GetById<Model.Vozilo>(_id);


            if (vozilo.Longitude == null && vozilo.Langitude == null)
            {
                MessageBox.Show("GPS nije u servisu!");
            }
            else
            {

                map.DragButton = MouseButtons.Left;
                map.MapProvider = GMapProviders.GoogleMap;

                //double laat = Convert.ToDouble(txtKlijent.Text);
                //double lon = Convert.ToDouble(txtVozilo.Text);

                double laat = (double)vozilo.Langitude;
                double lon = (double)vozilo.Longitude;


                map.Position = new PointLatLng(laat, lon);

                map.MinZoom = 1;
                map.MaxZoom = 100;
                map.Zoom = 10;

            }
        }
    }
}
