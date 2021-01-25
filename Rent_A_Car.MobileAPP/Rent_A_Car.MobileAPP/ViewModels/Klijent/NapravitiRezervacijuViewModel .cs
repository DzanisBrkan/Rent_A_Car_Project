using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class NapravitiRezervacijuViewModel
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacija");

        public NapravitiRezervacijuViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        public string _VrijemePocetka { get; set; } = null;
        public string _VrijemeRezervacije { get; set; } = null;
        public string _Kolicina { get; set; }
        public string _Status { get; set; } = null;
        public string _Cijena { get; set; } = null;
        public string _LokacijaId { get; set; } = null;
        public string _OsiguranjeId { get; set; } = null;
        public string _KlijentId { get; set; } = null;
        public string _VoziloId { get; set; } = null;
        public string _PopustId { get; set; } = null;
        public string _RacunID { get; set; } = null;


        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _rezervacijeService.Get<IEnumerable<Rezervacija>>(null);

            RezervacijeList.Clear();
            foreach (var rezervacije in list)
            {
                RezervacijeList.Add(rezervacije);
            }


            try
            {




                if (string.IsNullOrWhiteSpace(_VrijemePocetka))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate vrijeme pocetka rezervacije", "Ok");
                    return;


                }

                if (string.IsNullOrWhiteSpace(_VrijemeRezervacije))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ocjenu", "Ok");
                    return;


                }

                if (string.IsNullOrWhiteSpace(_Kolicina))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ocjenu", "Ok");
                    return;


                }


                if (string.IsNullOrWhiteSpace(_Status))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ocjenu", "Ok");
                    return;


                }

                if (string.IsNullOrWhiteSpace(_Cijena))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ocjenu", "Ok");
                    return;


                }






                var request = new RezervacijaUpsertRequest()
                {
                    VrijemePocetka = _VrijemePocetka,
                    VrijemeRezervacije = _VrijemeRezervacije,
                    Kolicina = _Kolicina,
                    Status = _Status,
                    Cijena = _Cijena
                    //LokacijaId = _LokacijaId,
                    //OsiguranjeId = _OsiguranjeId,
                    //KlijentId = _KlijentId,
                    //VoziloId = _VoziloId,
                    //PopustId = _PopustId,
                    //RacunId = _RacunID
                };



                var modelRezervacija = _rezervacijeService.Insert<Model.Rezervacija>(request);


                if (modelRezervacija != null)
                {
                    if (modelRezervacija.Status.ToString() != "Faulted")
                    {
                        await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspješno ste napravili rezervaicuju.", "Ok");
                        await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
                    }
                    //await Application.Current.MainPage.DisplayAlert("Error.", "Doslo je do greske.", "Ok");
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
