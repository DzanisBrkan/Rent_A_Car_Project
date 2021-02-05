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
    class SpecifikacijaVozilaViewModel : BaseViewModel
    {
        private readonly APIService _specifikacijaService = new APIService("Specifikacija");
        private readonly APIService _voziloService = new APIService("Vozilo");

        public int _voziloId = 0;
        public SpecifikacijaVozilaViewModel(int id)
        {
            _voziloId = id;
            InitCommand = new Command(() => Init());
            //GetVoziloCommand = new Command(async() => GetVozilo());
        }

        public int voziloId
        {
            get { return _voziloId; }
            set
            { SetProperty(ref _voziloId, value); }
        }

        //public ICommand GetVoziloCommand { get; set; }
        //public async Vozilo GetVozilo()
        //{
        //    return await _voziloService.GetById<Vozilo>(voziloId);
        //}
        public ObservableCollection<Specifikacija> SpecifikacijaList { get; set; } = new ObservableCollection<Specifikacija>();


        public ICommand InitCommand { get; set; }
        public async void Init()
        {
            var vozilo = await _voziloService.GetById<Vozilo>(_voziloId);
            var specId = vozilo.SpecifikacijaId;
            var specifikacija = await _specifikacijaService.GetById<Specifikacija>(specId);
            SpecifikacijaList.Clear();

            SpecifikacijaList.Add(specifikacija);

        }
    }
}
