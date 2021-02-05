using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.MobileAPP.Views.Klijent;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class KorisnickiPodaciViewModel : BaseViewModel
    {
        string _ime = string.Empty;


        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _gradService = new APIService("Grad");


        public KorisnickiPodaciViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SaveChangesCommand = new Command(async () => await SaveChanges());
        }
        public ObservableCollection<Model.Klijent> KlijentiList { get; set; } = new ObservableCollection<Model.Klijent>();
        public ObservableCollection<Grad> GradList { get; set; } = new ObservableCollection<Grad>();

         byte[] _SlikaThumb = null;
        public byte[] SlikaThumb
        {
            get { return _SlikaThumb; }
            set { SetProperty(ref _SlikaThumb, value); }
        }
        string _Ime = string.Empty;
        public string Ime
        {
            get { return _Ime; }
            set { SetProperty(ref _Ime, value); }
        }

        string _Prezime = string.Empty;
        public string Prezime
        {
            get { return _Prezime; }
            set { SetProperty(ref _Prezime, value); }
        }


        string _BrojTel = string.Empty;
        public string BrojTel
        {
            get { return _BrojTel; }
            set { SetProperty(ref _BrojTel, value); }
        }

        string _Email = string.Empty;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }

        string _Adresa = string.Empty;
        public string Adresa
        {
            get { return _Adresa; }
            set { SetProperty(ref _Adresa, value); }
        }

        string _DatumRodjenja = string.Empty;
        public string DatumRodjenja
        {
            get { return _DatumRodjenja; }
            set { SetProperty(ref _DatumRodjenja, value); }
        }

        int? _Grad = 0;
        public int? Grad
        {
            get { return _Grad; }
            set { SetProperty(ref _Grad, value); }
        }

        string _Password = string.Empty;
        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }


        string _PasswordConfirmation = string.Empty;
        public string PasswordConfirmation
        {
            get { return _PasswordConfirmation; }
            set { SetProperty(ref _PasswordConfirmation, value); }
        }

        string _Username = string.Empty;
        public string Username
        {
            get { return _Username; }
            set { SetProperty(ref _Username, value); }
        }


        Grad _selectedGrad = null;
        public Grad SelectedGrad
        {
            get { return _selectedGrad; }
            set
            {
                SetProperty(ref _selectedGrad, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }


        public ICommand SaveChangesCommand { get; set; }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            var gradList = await _gradService.Get<List<Grad>>(null);

            if(GradList.Count == 0)
            {
                foreach (var grad in gradList)
                {
                    GradList.Add(grad);
                }
            }

            //GradList.Clear();

            if (SelectedGrad != null)
            {
                Grad = SelectedGrad.GradId;
            }
            else
            {
                Grad = KlijentModel.GradId;
            }
            KlijentiList.Clear();
            KlijentiList.Add(KlijentModel);
            Ime = KlijentModel.Ime;
            Prezime = KlijentModel.Prezime;
            BrojTel = KlijentModel.BrojTel;
            Email = KlijentModel.Email;
            Adresa = KlijentModel.Adresa;
            DatumRodjenja = KlijentModel.DatumRodjenja;
            Username = KlijentModel.KorisnickoIme;
            SlikaThumb = KlijentModel.SlikaThumb;
        }



        public async Task SaveChanges()
        {


            //if (NewPassword != NewPasswordConfirmation)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Greška", "Nove Lozinke se ne podudaraju!", "Unesite ponovo");
            //    return;
            //}
            var listUsers = await _klijentService.Get<List<Model.Klijent>>(null);

            if (Username != null)
            {
                foreach (var item in listUsers)
                {
                    if (Username == item.KorisnickoIme && item.KlijentId != APIService.UserID)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime već postoji.", "Pokušajte ponovo");
                        return;
                    }
                }
            }
            //Name
            if (string.IsNullOrWhiteSpace(Ime) || Ime.Length < 3)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Ime je obavezno polje!Minimalna dužina mora biti 3 karaktera", "Ok");
                return;


            }

            if (char.IsLower(Ime[0]))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prvo slovo imena mora biti veliko!", "Ok");
                return;
            }
            bool containsInt = Ime.Any(char.IsDigit);
            if (containsInt)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Brojevi u imenu nisu dozovljeni!", "Ok");
                return;
            }

            //Last name
            if (string.IsNullOrWhiteSpace(Prezime) || Prezime.Length < 3)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prezime je obavezno polje!Minimalna dužina mora biti 3 karaktera", "Ok");
                return;


            }

            if (char.IsLower(Prezime[0]))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prvo slovo prezimena mora biti veliko!", "Ok");
                return;
            }
            bool containsInta = Prezime.Any(char.IsDigit);
            if (containsInta)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Brojevi u prezimenu nisu dozovljeni!", "Ok");
                return;
            }
            //Email

            if (string.IsNullOrWhiteSpace(Email))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Email je obavezno polje!", "Ok");
                return;
            }

            if (!Regex.IsMatch(Email, @"([a-z]+)([\\.]?)([a-z]*)([@])(yahoo|outlook|gmail|hotmail|fit|edu.fit)(.ba|.com|.org)"))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Email mora biti u formatu: nešto@(gmail,hotmail,fit,edu.fit,outlook,yahoo).(ba,com,org)", "Ok");
                return;
            }

            //PhoneNumber
            if (string.IsNullOrWhiteSpace(BrojTel))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Broj telefona je obavezno polje!", "Ok");
                return;
            }

            if (!Regex.IsMatch(BrojTel, @"(06[0-9])([/])([0-9]){3}([-])([0-9]){3}$"))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Broj telefona mora biti u formatu: 06X/XXX-XXX", "Ok");
                return;
            }

            //Username
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime je obavezno polje!Minimalna dužina mora biti 3 karaktera", "Ok");
                return;
            }


            var request = new KlijentInsertRequest()
            {
                Ime = Ime,
                Prezime = Prezime,
                DatumRodjenja = DatumRodjenja,
                Email = Email,
                BrojTel = BrojTel,
                KorisnickoIme = Username,
                Adresa = Adresa,
                GradId =SelectedGrad.GradId,
                Password = Password,
                PasswordConfirmation = PasswordConfirmation
            };
            //if (CityModel != null)
            //    request.CityID = CityModel.CityID;

            //if (CarModel != null)
            //{
            //    request.CarModelID = CarModel.CarModelID;
            //    request.CarBrandID = CarModel.CarBrandID;
            //}

            //if (!string.IsNullOrEmpty(NewPassword))
            //{
            //    request.Password = NewPassword;
            //    request.PasswordConfirmation = NewPasswordConfirmation;
            //}


            var modelUserUpdated = await _klijentService.Update<Model.Klijent>(APIService.UserID, request);


            if (modelUserUpdated != null)
            {
                await Application.Current.MainPage.DisplayAlert("Uspješno", "Izmijene uspješno napravljenje. Prijavite se ponovo da bi se podaci osvježili.", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
        }
    }
}
