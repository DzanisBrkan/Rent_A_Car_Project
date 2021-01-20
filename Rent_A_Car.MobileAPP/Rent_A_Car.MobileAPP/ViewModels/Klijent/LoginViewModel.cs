using Rent_A_Car.MobileAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        private readonly APIService _service = new APIService("Klijent");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        
        }

        public

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }


        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
          
            try
            {

                //var klijent = await _service.Get<Model.Klijent>(null);              
                //if (klijent != null)
                //{
                    await _service.Get<dynamic>(null);
                    Application.Current.MainPage = new MainPage();
                //    APIService.LogovaniKlijent = klijent;
                //    return;
                //}

            }
            catch (Exception ex)
            {
                //ovo ne smije biti tu
                //Application.Current.MainPage = new MainPage();

            }

        }
    }
}
