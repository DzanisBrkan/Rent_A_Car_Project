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

        }


        public ObservableCollection<Ugovor> UgovorList { get; set; } = new ObservableCollection<Ugovor>();
        public ObservableCollection<Ugovor> _PronadjeniUgovorService { get; set; } = new ObservableCollection<Ugovor>();

        public ObservableCollection<Ugovor> RezervacijaList { get; set; } = new ObservableCollection<Ugovor>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

            //if (APIService.UserRacunID != 0)
            //{
            //    var Racun = await _UgovorService.GetById<Model.Ugovor>(APIService.UserRacunID);
            //}

            //kom//ovdje bi trebo napraviti request ili nesto da poredi iz REZERVACIJE id klijenta
            //kom//var RezervacijaModel = await _rezervacijaService.GetById<Model.Rezervacija>(KlijentModel.KlijentId);
            //kom//RezervacijeList.Clear();
            //kom//RezervacijeList.Add(RezervacijaModel);

            //var list = await _UgovorService.Get<IEnumerable<Ugovor>>(null);

            //UgovorList.Clear();
            //RezervacijaList.Clear();
            //foreach (var ugovor in list)
            //{
            //    UgovorList.Add(ugovor);
            //}


            //kom//trebam provjerit da li je APIService.UserUgovorID prazan 
            //for (int i = 0; i < UgovorList.Count; i++)
            //{
            //    kom//if (UgovorList[i].RacunID == APIService.UserRacunID)
            //    kom//{
            //    kom//    RezervacijaList.Add(UgovorList[i]);
            //    kom//}
            //}
            if(APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }
            var list = await _UgovorService.Get<IEnumerable<Ugovor>>(null);

            UgovorList.Clear();
            _PronadjeniUgovorService.Clear();
            foreach (var ugovor in list)
            {
                UgovorList.Add(ugovor);
            }

            var rezervacija = await _RezervacijaService.GetActionResponse<Rezervacija>($"GetRezByUserID/{APIService.UserID}");

            for (int i = 0; i < UgovorList.Count; i++)
            {
                if (UgovorList[i].RezervacijaId == rezervacija.RezervacijaID && UgovorList[i].Izdano == false)
                {
                    _PronadjeniUgovorService.Add(UgovorList[i]);
                }
            }
        }
    }
}
