using GalaSoft.MvvmLight.Command;
using Rent_A_Car.MobileAPP.Views.Klijent;
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
    public class DetaljiVozilaViewModel : BaseViewModel
    {

        private readonly APIService _vozilaService = new APIService("Vozilo");
        private readonly APIService _tipVozilaService = new APIService("Tip");
        private Vozilo _voziloDetalji = null;


        public DetaljiVozilaViewModel()
        {
            _voziloDetalji = null;
            InitCommand = new Command(() => Init());
        }

        public DetaljiVozilaViewModel(Vozilo vozilo)
        {
            _voziloDetalji = vozilo;
            InitCommand = new Command(() => Init());
            SpecifikacijeCommand = new Command(async () => await Specifikacije());

        }


        public ObservableCollection<Vozilo> VozilaList { get; set; } = new ObservableCollection<Vozilo>();
        //public ObservableCollection<Tip> TipVozila { get; set; } = new ObservableCollection<Tip>();



        public ICommand InitCommand { get; set; }

        public void Init()
        {

           VozilaList.Clear();
          
           VozilaList.Add(_voziloDetalji);
           
        }


        public ICommand SpecifikacijeCommand { private set; get; }
        public async Task Specifikacije()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new SpecifikacijaVozilaPage(_voziloDetalji.VoziloID));
        }
    }
}
