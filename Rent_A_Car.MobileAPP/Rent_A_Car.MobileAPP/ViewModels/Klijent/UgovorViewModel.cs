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
    public class UgovorViewModel : BaseViewModel
    {
        private readonly APIService _RezervacijaService = new APIService("Rezervacija");
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _UgovorService = new APIService("Ugovor");


        public UgovorViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OstaviDojamCommand = new Command(async () => await OstaviDojam());
        }

        string _NazivPlacanja = string.Empty;
        public string NazivPlacanja
        {
            get { return _NazivPlacanja; }
            set
            {
                SetProperty(ref _NazivPlacanja, value);
            }
        }

        public ObservableCollection<Ugovor> UgovorList { get; set; } = new ObservableCollection<Ugovor>();
        public ObservableCollection<Ugovor> _PronadjeniUgovorService { get; set; } = new ObservableCollection<Ugovor>();
        public ObservableCollection<Rezervacija> RezervacijaList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> _PronadjenaRezervacijaList { get; set; } = new ObservableCollection<Rezervacija>();


        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            
            if(APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }
            var list = await _UgovorService.Get<IEnumerable<Ugovor>>(null);
            var listRez = await _RezervacijaService.Get<IEnumerable<Rezervacija>>(null);

            UgovorList.Clear();
            RezervacijaList.Clear();
            _PronadjenaRezervacijaList.Clear();
            _PronadjeniUgovorService.Clear();

            foreach (var ugovor in list)
            {
                UgovorList.Add(ugovor);
            }
            foreach(var rez in listRez)
            {
                RezervacijaList.Add(rez);
            }

            
            for(int i=0;i<RezervacijaList.Count;i++)
            {
                if(RezervacijaList[i].KlijentId == APIService.UserID)
                {
                    _PronadjenaRezervacijaList.Add(RezervacijaList[i]);
                }
            }

            for (int i = 0; i < UgovorList.Count; i++)
            {
                for(int j = 0; j < _PronadjenaRezervacijaList.Count; j++)
                {
                    if (UgovorList[i].RezervacijaId == _PronadjenaRezervacijaList[j].RezervacijaID && UgovorList[i].Izdano == true)
                    {
                        _PronadjeniUgovorService.Add(UgovorList[i]);
                       
                    }
                }
                
            }
        }

        public ICommand OstaviDojamCommand { get; set; }
        public async Task OstaviDojam()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new DojamZahtjevPage());

        }
    }
}
