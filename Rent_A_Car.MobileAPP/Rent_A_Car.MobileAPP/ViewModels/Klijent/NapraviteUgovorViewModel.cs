using Rent_A_Car.MobileAPP.Views.Klijent;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class NapraviteUgovorViewModel : BaseViewModel
    {
        int? VoziloID = null;
        double? VoziloCijena = null;

        private readonly APIService _klijentService = new APIService("Klijent");

        private readonly APIService _UgovorService = new APIService("Ugovor");
        private readonly APIService _VozilaService = new APIService("Vozilo");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");



        public NapraviteUgovorViewModel(int? voziloId = null, double? voziloCijena = null)
        {
            InitCommand = new Command(async () => await Init());
            SaveChangesCommand = new Command(async () => await SaveChanges());

            VoziloID = voziloId;
            VoziloCijena = voziloCijena;
        }

        public DateTime? _DatumUgovora = null;
        public DateTime? DatumUgovora
        {
            get { return _DatumUgovora; }
            set { SetProperty(ref _DatumUgovora, value); }
        }


        double _CijenaAutomobila = 0;
        public double CijenaAutomobila
        {
            get { return _CijenaAutomobila; }
            set { SetProperty(ref _CijenaAutomobila, value); }
        }

        string _UkupnaKolicina = string.Empty;
        public string UkupnaKolicina
        {
            get { return _UkupnaKolicina; }
            set { SetProperty(ref _UkupnaKolicina, value); }
        }


        string _NacinPlacanja = string.Empty;
        public string NacinPlacanja
        {
            get { return _NacinPlacanja; }
            set { SetProperty(ref _NacinPlacanja, value); }
        }



        int _VoziloId = 0;
        public int VoziloId
        {
            get { return _VoziloId; }
            set { SetProperty(ref _VoziloId, value); }
        }


        //public string _DatumUgovora { get; set; }
        //public string _CijenaAutomobila { get; set; }
        //public string _UkupnaKolicina { get; set; }
        //public string _NacinPlacanja { get; set; }



        public ObservableCollection<Ugovor> UgovorList { get; set; } = new ObservableCollection<Ugovor>();

        public ObservableCollection<Vozilo> VoziloList { get; set; } = new ObservableCollection<Vozilo>();
        public ObservableCollection<Vozilo> _PronadjenaVozilaService { get; set; } = new ObservableCollection<Vozilo>();

        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> _PronadjenaRezervacijaService { get; set; } = new ObservableCollection<Rezervacija>();


        public ICommand SaveChangesCommand { get; set; }



        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
                //mls da ovo ne treba  
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
                var VoziloModel = await _VozilaService.GetById<Model.Vozilo>(VoziloID);
                APIService.UserVoziloID = (int)VoziloID;

            // NAJBITNI KONTROLER IKADA NAPISAN

            //var RezervacijaModel = await _rezervacijaService.GetActionResponse<Model.Rezervacija>($"GetRezByUserID/{APIService.UserID}");

            //var UgovorModel = await _UgovorService.GetById<Model.Ugovor>(RezervacijaModel.RacunId);
            //APIService.UserRacunID = RezervacijaModel.RacunId;

            //var listaVozila = await _rezervacijaService.GetById<Vozilo>(RezervacijaModel.VoziloId);


            //VoziloList.Clear();
            //_PronadjenaVozilaService.Clear();
            //foreach (var rezervacije in listaVozila)
            //{
            //    VoziloList.Add(rezervacije);
            //}

            //for (int i = 0; i < VoziloList.Count; i++)
            //{
            //    if (VoziloList[i].VoziloID == TrazenaRezervacija.VoziloId)
            //    {
            //        _PronadjenaVozilaService.Add(VoziloList[i]);
            //    }
            //}

            //UgovorList.Clear();
            //UgovorList.Add(UgovorModel);

            DatumUgovora = DateTime.Now;
                 CijenaAutomobila = (double)VoziloCijena;
                 UkupnaKolicina = UkupnaKolicina;
                 NacinPlacanja = NacinPlacanja;
                 VoziloId = (int)VoziloID;

        }

        public async Task SaveChanges()
        {
            if (DatumUgovora == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti datum", "Ok");
                return;


            }

            if (CijenaAutomobila < 0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti cjenu", "Ok");
                return;


            }

            if (string.IsNullOrWhiteSpace(UkupnaKolicina))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti kolicinu", "Ok");
                return;


            }
            if (string.IsNullOrWhiteSpace(NacinPlacanja))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti nacin placanja", "Ok");
                return;


            }


            var request = new UgovorUpsertRequest()
            {
                //DatumUgovora = DateTime.Now,
                //DatumUgovora = DatumUgovora,
                //CijenaAutomobila = CijenaAutomobila.ToString(),
                //UkupnaKolicina = UkupnaKolicina,
                //NacinPlacanjaId = NacinPlacanja,
                //NacinPlacanja
                //VoziloID = VoziloID.ToString()
                


            };


            var modelDojam = await _UgovorService.Insert<Model.Ugovor>(request);



            if (modelDojam != null)
            {
                //if (modelDojam.Status.ToString() != "Faulted")
                //{
                APIService.UserRacunID = modelDojam.RacunID;
                    await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspješno ste kreirali ugovor.", "Ok");
                    await Application.Current.MainPage.Navigation.PushModalAsync(new NapraviRezervaciju());
                // provjeri ovdje radi li poslije ovoga APLIKACIJA  
                //}
                //await Application.Current.MainPage.DisplayAlert("Error.", "Doslo je do greske.", "Ok");
            }



        }

    }
}
