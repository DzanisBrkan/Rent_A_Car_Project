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

        private readonly APIService _service = new APIService("Zaposlenik");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        //USERNAME
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        //PASSWORD
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        //Komand patern - sluzi za povezivanje sa view modelom
        public ICommand LoginCommand { get; set; } //icomand interface omogucava da povezujemo butone itd sa komandama

        async Task Login()
        {
            IsBusy = true;

            //odavde isto kao u win formi login
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();

            }
            catch (Exception ex)
            {
                //
            } 
              
        }
    }
}
