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

        private readonly APIService _UgovorService = new APIService("Ugovor");


        public UgovorViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        public ObservableCollection<Ugovor> UgovorList { get; set; } = new ObservableCollection<Ugovor>();
        public ObservableCollection<Ugovor> RezervacijaList { get; set; } = new ObservableCollection<Ugovor>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

            if (APIService.UserRacunID != 0)
            {
                var Racun = await _UgovorService.GetById<Model.Ugovor>(APIService.UserRacunID);
            }

            //ovdje bi trebo napraviti request ili nesto da poredi iz REZERVACIJE id klijenta
            //var RezervacijaModel = await _rezervacijaService.GetById<Model.Rezervacija>(KlijentModel.KlijentId);

            //RezervacijeList.Clear();
            //RezervacijeList.Add(RezervacijaModel);

            var list = await _UgovorService.Get<IEnumerable<Ugovor>>(null);

            UgovorList.Clear();
            RezervacijaList.Clear();
            foreach (var ugovor in list)
            {
                UgovorList.Add(ugovor);
            }


            //trebam provjerit da li je APIService.UserUgovorID prazan 
            for (int i = 0; i < UgovorList.Count; i++)
            {
                if (UgovorList[i].RacunID == APIService.UserRacunID)
                {
                    RezervacijaList.Add(UgovorList[i]);

                }
            }
        }
    }
}
