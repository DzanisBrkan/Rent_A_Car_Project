using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class KorisnickiPodaciViewModel : BaseViewModel
    {
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }


        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }


        string _brojTelefona = string.Empty;
        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { SetProperty(ref _brojTelefona, value); }
        }




        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }



        string _adresa = string.Empty;
        public string Adresa
        {
            get { return _adresa; }
            set { SetProperty(ref _adresa, value); }
        }


        string _datumrodjenja = string.Empty;
        public string DatumRodjenja
        {
            get { return _datumrodjenja; }
            set { SetProperty(ref _datumrodjenja, value); }
        }





        //private readonly APIService _klijentiService = new APIService("Klijenti");
        //private int _klijentId;
        //private Model.KlijentiUpdateRequest _klijent;
        //public Model.KlijentiUpdateRequest Klijent
        //{
        //    get { return _klijent; }
        //    set { SetProperty(ref _klijent, value); }
        //}
        //public ICommand SpasiProfilCommand { get; set; }
        //public KorisnickiPodaciViewModel()
        //{
        //    SpasiProfilCommand = new Command(async () => await SpasiProfil());
        //}

        //public async Task Init()
        //{
        //    _klijentId = APIService.LogovaniKlijent.KlijentId;
        //    await LoadUser();
        //}
        //private async Task LoadUser()
        //{
        //    Klijent = await _klijentiService.GetById<Model.KlijentiUpdateRequest>(_klijentId);

        //    Title = Klijent.KorisnickoIme + "- Korisnicki podaci";


        //}
        //private async Task SpasiProfil()
        //{
        //    var entity = await _klijentiService.Update<Model.Klijenti>(APIService.LogovaniKlijent.KlijentId, Klijent);
        //    if (entity != null)
        //    {
        //        APIService.Username = Klijent.KorisnickoIme;
        //        if (!string.IsNullOrEmpty(Klijent.Password))
        //        {
        //            APIService.Password = Klijent.Password;
        //        }

        //        await Application.Current.MainPage.DisplayAlert("Uspjeh", "Izmjene profila su uspješno sačuvane.", "OK");
        //        Application.Current.MainPage = new MainPage();
        //    }
        //}
    }
}
