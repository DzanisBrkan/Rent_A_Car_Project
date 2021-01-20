using Rent_A_Car.MobileAPP.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Rent_A_Car.Model.Requests;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _serviceKlijenti = new APIService("Klijent");
        private readonly APIService _serviceGradovi = new APIService("Gradovi");

        public RegistracijaViewModel()
        {
            RegistracijaCommand = new Command(async () => await Register());
            Title = "Registracija";
            _klijent = new KlijentInsertRequest();
        }



        private bool _isButtonEnabled = true;
        public bool IsButtonEnabled
        {
            get { return _isButtonEnabled; }
            set { SetProperty(ref _isButtonEnabled, value); }
        }

        //public ObservableCollection<Model.Gradovi> Gradovi { get; set; } = new ObservableCollection<Gradovi>();
        //private Model.Gradovi _grad;


        //public Model.Gradovi Grad
        //{
        //    get { return _grad; }
        //    set { SetProperty(ref _grad, value); }
        //}

        private KlijentInsertRequest _klijent;
        public KlijentInsertRequest Klijent
        {
            get { return _klijent; }
            set { SetProperty(ref _klijent, value); }
        }

        public async Task Init()
        {
            //    var listGradovi = await _serviceGradovi.Get<List<Model.Gradovi>>(null);
            //    foreach (var grad in listGradovi)
            //    {
            //        Gradovi.Add(grad);
            //    }
        }


        public ICommand RegistracijaCommand { get; set; }

        async Task Register()
        {
            IsButtonEnabled = false;

            try
            {
                //if (Grad != null)
                //    Klijent.GradId = Grad.GradId;

                var entity = await _serviceKlijenti.Insert<Model.Klijent>(Klijent);
                if (entity == null)
                    throw new Exception();

                APIService.Username = Klijent.KorisnickoIme;
                APIService.Password = Klijent.Password;

                //var request = new LoginSearchRequest
                //{
                //    KorisnickoIme = APIService.Username,
                //    Lozinka = APIService.Password
                //};
                //APIService.LogovaniKlijent = await _serviceKlijenti.Get<Model.Klijent>(request, "login");
                APIService.LogovaniKlijent = await _serviceKlijenti.Get<Model.Klijent>(null);


                Application.Current.MainPage = new MainPage();
            }
            catch (Exception)
            {

            }
            finally
            {
                IsButtonEnabled = true;
            }
        }

    }
}
