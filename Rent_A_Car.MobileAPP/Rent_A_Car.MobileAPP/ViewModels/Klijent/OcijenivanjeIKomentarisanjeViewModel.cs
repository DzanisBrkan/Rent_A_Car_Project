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
    class OcijenivanjeIKomentarisanjeViewModel : BaseViewModel
    {
        private readonly APIService _klijentService = new APIService("Klijent");

        private readonly APIService _komentariIOcijeneService = new APIService("Ocjena");
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _UgovorService = new APIService("Ugovor");

        public OcijenivanjeIKomentarisanjeViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }

        public ObservableCollection<Ocjena> OcijeneList { get; set; } = new ObservableCollection<Ocjena>();
        public ObservableCollection<Ocjena> PronadjenaOcjenaList { get; set; } = new ObservableCollection<Ocjena>();
        public ObservableCollection<Vozilo> VozilaList { get; set; } = new ObservableCollection<Vozilo>();
        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> PronadjenaRezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Ugovor> UgovorList { get; set; } = new ObservableCollection<Ugovor>();



        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            //var listOcjena = await _komentariIOcijeneService.Get<IEnumerable<Ocjena>>(null);

            //OcijeneList.Clear();
            //foreach (var ocijene in listOcjena)
            //{
            //    OcijeneList.Add(listOcjena);
            //}

            //==========================================================================

            
            if (APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }



            //var list = await _rezervacijaService.Get<IEnumerable<Rezervacija>>(null);
            //var listOcjenaa = await _komentariIOcijeneService.Get<IEnumerable<Ocjena>>(null);

            //var ModelRezervacija = await _rezervacijaService.GetById<IEnumerable<Rezervacija>>(APIService.UserID);
            var ListaRezervacija = await _rezervacijaService.Get<IEnumerable<Rezervacija>>(null);


            var ListaOcjenaa = await _komentariIOcijeneService.Get<IEnumerable<Ocjena>>(null);


            RezervacijeList.Clear();
            PronadjenaOcjenaList.Clear();
            UgovorList.Clear();
            VozilaList.Clear();
            OcijeneList.Clear();

            int brojacRezervacijaList = 0;
            foreach (var rezervacija in ListaRezervacija)
            {
                RezervacijeList.Add(rezervacija);
            }

            for (int i = 0; i < RezervacijeList.Count; i++)
            {
                if (RezervacijeList[i].KlijentId == APIService.UserID)
                {
                    PronadjenaRezervacijeList.Add(RezervacijeList[i]);
                    brojacRezervacijaList++;
                }
            }





            foreach (var ocjena in ListaOcjenaa)
            {
                OcijeneList.Add(ocjena);
            }

             var brojacRezervacijaList2 = 0;

            for (int i = 0; i < OcijeneList.Count; i++)
            {
                if (brojacRezervacijaList2 == brojacRezervacijaList)
                {
                    brojacRezervacijaList2 = 0;

                }

                if (OcijeneList[i].RezervacijaId == PronadjenaRezervacijeList[brojacRezervacijaList2].RezervacijaID)
                {
                    
                    brojacRezervacijaList2++;
                    PronadjenaOcjenaList.Add(OcijeneList[i]);
                }
            }
            brojacRezervacijaList = 0;
        }
    }
}
