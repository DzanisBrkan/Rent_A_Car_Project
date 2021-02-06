using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class OcjenjivanjeViewModel : BaseViewModel
    {
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _komentariIOcijeneService = new APIService("Ocjena");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");

        public string _rezervacijaId = string.Empty;

        public OcjenjivanjeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OcjeniCommand = new Command(async () => await Ocjeni());
        }

        public OcjenjivanjeViewModel(string rezervacijaId)
        {
            InitCommand = new Command(async () => await Init());
            OcjeniCommand = new Command(async () => await Ocjeni());

            _rezervacijaId = rezervacijaId;
        }


        int _Ocjena = 0;
        public int Ocjena
        {
            get { return _Ocjena; }
            set
            { SetProperty(ref _Ocjena, value); }
        }

        string _Komentar = string.Empty;
        public string Komentar
        {
            get { return _Komentar; }
            set
            { SetProperty(ref _Komentar, value); }
        }



        public bool IsUpdate = false;
        public int ocjenaID = 0;

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
           
            if (APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }
            var ocjena = await _komentariIOcijeneService.GetActionResponse<Model.Ocjena>($"GetOcjByRezID/{_rezervacijaId}");
            if(ocjena != null)
            {
                IsUpdate = true;
                ocjenaID = ocjena.OcjenaId;
                Ocjena = ocjena.Ocjena1;
                Komentar = ocjena.Komentar;
            }
            
        }

        public ICommand OcjeniCommand { get; set; }
        public async Task Ocjeni()
        {
            var rezervacija = await _rezervacijaService.GetById<Model.Rezervacija>(int.Parse(_rezervacijaId));

            if (IsUpdate == true)
            {
                var requestOcjena = new OcjenaUpsertRequest()
                {
                    Ocjena1 = Ocjena,
                    Komentar = Komentar,
                    RezervacijaId = int.Parse(_rezervacijaId),
                    VoziloId = rezervacija.VoziloId,
                    KlijentId = rezervacija.KlijentId
                };
                var modelOcjena = await _komentariIOcijeneService.Update<Model.Ocjena>(ocjenaID, requestOcjena);
                if (modelOcjena != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Notifikacija", "Rezervacija uspješno ocijenjena!", "Ok");

                }
            }
            else
            {
                var requestOcjena = new OcijenaInsertRequest()
                {
                    Ocjena1 = Ocjena,
                    Komentar = Komentar,
                    RezervacijaId = int.Parse(_rezervacijaId),
                    VoziloId = rezervacija.VoziloId,
                    KlijentId = rezervacija.KlijentId
                };
                var modelOcjena = await _komentariIOcijeneService.Insert<Model.Ocjena>(requestOcjena);
                if (modelOcjena != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Notifikacija", "Rezervacija uspješno ocijenjena!", "Ok");

                }
            }
            
        }
    }
}
