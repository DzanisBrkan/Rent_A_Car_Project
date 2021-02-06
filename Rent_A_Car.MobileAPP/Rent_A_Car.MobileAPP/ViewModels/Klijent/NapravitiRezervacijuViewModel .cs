using Rent_A_Car.MobileAPP.Views;
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
    public class NapravitiRezervacijuViewModel : BaseViewModel
    {
        private readonly APIService _klijentService = new APIService("Klijent");

        private readonly APIService _rezervacijeService = new APIService("Rezervacija");
        private readonly APIService _vozilaService = new APIService("Vozilo");






        private readonly APIService _UgovorService = new APIService("Ugovor");
        private readonly APIService _VozilaService = new APIService("Vozilo");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");

        public NapravitiRezervacijuViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SaveChangesCommand = new Command(async () => await SaveChanges());


        }

        public DateTime _KrajRezervacije;
        public DateTime KrajRezervacije
        {
            get { return _KrajRezervacije; }
            set { SetProperty(ref _KrajRezervacije, value); }
        }


        string _Status = string.Empty;
        public string Status
        {
            get { return _Status; }
            set { SetProperty(ref _Status, value); }
        }


        string _UkupnaCijena = string.Empty;
        public string UkupnaCijena
        {
            get { return _UkupnaCijena; }
            set { SetProperty(ref _UkupnaCijena, value); }
        }

        //string _LokacijaId = string.Empty;
        //public string LokacijaId
        //{
        //    get { return _LokacijaId; }
        //    set { SetProperty(ref _LokacijaId, value); }
        //}

        //string _OsiguranjeId = string.Empty;
        //public string OsiguranjeId
        //{
        //    get { return _OsiguranjeId; }
        //    set { SetProperty(ref _OsiguranjeId, value); }
        //}

        //string _KlijentId = string.Empty;
        //public string KlijentId
        //{
        //    get { return _KlijentId; }
        //    set { SetProperty(ref _KlijentId, value); }
        //}

        //string _VoziloId = string.Empty;
        //public string VoziloId
        //{
        //    get { return _VoziloId; }
        //    set { SetProperty(ref _VoziloId, value); }
        //}

        //string _PopustId = string.Empty;
        //public string PopustId
        //{
        //    get { return _PopustId; }
        //    set { SetProperty(ref _PopustId, value); }
        //}

        string _RacunID = string.Empty;
        public string RacunID
        {
            get { return _RacunID; }
            set { SetProperty(ref _RacunID, value); }
        }

        //public string _KrajRezervacije { get; set; } = null;

        //public string _Status { get; set; } = null;
        //public string _UkupnaCijena { get; set; } = null;
        //public string _LokacijaId { get; set; } = null;
        //public string _OsiguranjeId { get; set; } = null;
        //public string _KlijentId { get; set; } = null;
        //public string _VoziloId { get; set; } = null;
        //public string _PopustId { get; set; } = null;
        //public string _RacunID { get; set; } = null;


        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();

        public ObservableCollection<Ugovor> UgovorList { get; set; } = new ObservableCollection<Ugovor>();
        public ObservableCollection<Ugovor> UgovorList2 { get; set; } = new ObservableCollection<Ugovor>();



        public ICommand SaveChangesCommand { get; set; }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

            //var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);

            //var list = await _rezervacijeService.Get<IEnumerable<Rezervacija>>(null);
            //var modelVozilo = await _vozilaService.GetById<IEnumerable<Vozilo>>(APIService.UserVoziloID);

            //RezervacijeList.Clear();
            //foreach (var rezervacije in list)
            //{
            //    RezervacijeList.Add(rezervacije);
            //}

            ////treba napraviti funkciju koja pretvara datum u dane pa to u sate
            //var cijenaVozila = modelVozilo.First().CijenaPoSatu * 10;

            //KrajRezervacije = RezervacijeList.First().KrajRezervacije;
            //Status = RezervacijeList.First().Status;
            //UkupnaCijena = cijenaVozila.ToString();

            //LokacijaId = RezervacijeList.First().LokacijaId.ToString();
            //OsiguranjeId = RezervacijeList.First().OsiguranjeId.ToString();
            //KlijentId = RezervacijeList.First().KlijentId.ToString();
            //VoziloId = RezervacijeList.First().VoziloId.ToString();
            //PopustId = RezervacijeList.First().PopustId.ToString();
            //RacunID = RezervacijeList.First().RacunId.ToString();

            //var RezervacijaModel = await _rezervacijeService.GetById<Model.Rezervacija>(APIService.UserID);

            var RezervacijaModel = await _rezervacijaService.GetActionResponse<Model.Rezervacija>($"GetRezByUserID/{APIService.UserID}");

            var ListaUgovora = await _UgovorService.GetById<Ugovor>(APIService.UserRacunID);
            //var VozilModel = await _vozilaService.GetById<Vozilo>(APIService.UserVoziloID);

            //UgovorList.Clear();
            //foreach (var rezervacije in ListaUgovora)
            //{
            //    UgovorList.Add(rezervacije);
            //}

            //for (int i = 0; i < UgovorList.Count; i++)
            //{
            //    if (UgovorList[i].RacunID == ListaUgovora.RacunID)
            //    {
            //        UgovorList2[i] = UgovorList[i];
            //    }
            //}



            RacunID = ListaUgovora.RacunID.ToString();
            KrajRezervacije = _KrajRezervacije;
            Status = _Status;

            //var DatetimeNow = DateTime.Now;
            //var daniUMjesecu = DateTime.DaysInMonth(DateTime.Now.Month ,DateTime.Now.Month);
            //char[] unjetiDani = KrajRezervacije.Take(2).ToArray();
            //var unjetiDaniInt = Int32.Parse(unjetiDani.ToString()); 
            //var ukupnaCijena = VozilModel.CijenaPoSatu * (daniUMjesecu-unjetiDaniInt);



            UkupnaCijena = _UkupnaCijena;

        }

        public async Task SaveChanges()
        {
            


            try
            {

                if (KrajRezervacije != null)
                {
                    if (KrajRezervacije.Month < DateTime.Now.Month)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ispravan datum", "Ok");
                        //return;
                    }
                  


                }



                if (string.IsNullOrWhiteSpace(Status))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti status", "Ok");
                    return;


                }

                //if (string.IsNullOrWhiteSpace(UkupnaCijena))
                //{
                //    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ocjenu", "Ok");
                //    return;


                //}



                //i ovdje unijeti
            
                var RezervacijaModel = await _rezervacijaService.GetActionResponse<Model.Rezervacija>($"GetRezByUserID/{APIService.UserID}");

                //get last Racun(ugvoor)
                var UgovorModel = await _UgovorService.GetById<Model.Ugovor>(RezervacijaModel.RacunId);
                APIService.UserRacunID = RezervacijaModel.RacunId;



                var VozilModel = await _vozilaService.GetById<Vozilo>(APIService.UserVoziloID);
                //var ugovorModel = await _UgovorService.GetById<Ugovor>(APIService.UserRacunID);


                var DatumUgovora = DateTime.Now.Day;

                var KrajDatumaUgovora = KrajRezervacije.Day;

                int DaniRezervacije = 0;
                int ukupnaCijena = 0;

                //if (KrajRezervacije.Month >= DateTime.Now.Month)
                //{
                    if (KrajDatumaUgovora < DatumUgovora)
                    {
                        DatumUgovora = 0;
                    }
                    DaniRezervacije = KrajDatumaUgovora - DatumUgovora;
                    ukupnaCijena = (int)VozilModel.CijenaPoSatu * DaniRezervacije;
                //}


              



                var request = new RezervacijaUpsertRequest()
                {
                    KrajRezervacije = KrajRezervacije,
                    Status = Status,
                    UkupnaCijena = ukupnaCijena.ToString(),
                    //LokacijaId = _LokacijaId,
                    //OsiguranjeId = _OsiguranjeId,
                    KlijentId = APIService.UserID,
                    //VoziloId = _VoziloId,
                    //PopustId = _PopustId,
                    RacunId = APIService.UserRacunID
                };



                var modelRezervacija = await _rezervacijeService.Insert<Model.Rezervacija>(request);


                if (modelRezervacija != null)
                {
                    //if (modelRezervacija.Status.ToString() != "Faulted")
                    //{
                        await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspješno ste napravili rezervaicuju. Cijena iznosi:" + ukupnaCijena.ToString() + "KM", "Ok");
                        //await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
                    //}
                    //await Application.Current.MainPage.DisplayAlert("Error.", "Doslo je do greske.", "Ok");
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
