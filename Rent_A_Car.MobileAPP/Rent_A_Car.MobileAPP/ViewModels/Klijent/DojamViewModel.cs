using Rent_A_Car.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    class DojamViewModel : BaseViewModel
    {
        private readonly APIService _komentariIOcijeneService = new APIService("Ocjena");

        public DojamViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        string _komentar = string.Empty;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }


        string _ocijena = string.Empty;
        public string Ocijena
        {
            get { return _ocijena; }
            set { SetProperty(ref _ocijena, value); }
        }




        public ObservableCollection<Ocjena> OcijeneList { get; set; } = new ObservableCollection<Ocjena>();

        public ICommand InitCommand { get; set; }

        //public async Task Init()
        //{
        //    var list = await _komentariIOcijeneService.Get<IEnumerable<Ocjena>>(null);

        //    OcijeneList.Clear();
        //    foreach (var ocijene in list)
        //    {
        //        OcijeneList.Add(ocijene);
        //    }
        //}


        async Task Init()
        {
            //TREBO BI DA UNESE OCIJENU I KOMENTAR - TREBA API ZA INSERT

            //IsBusy = true;
            //APIService.Username = Username;
            //APIService.Password = Password;

            //try
            //{
            //    await _service.Get<dynamic>(null);
            //    Application.Current.MainPage = new MainPage();

            //}
            //catch (Exception ex)
            //{
            //    //ovo ne smije biti tu
            //    Application.Current.MainPage = new MainPage();

            //}

        }

    }
}
