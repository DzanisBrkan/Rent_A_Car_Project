using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Rent_A_Car.MobileAPP.Models;
using Rent_A_Car.MobileAPP.Views.Klijent;

namespace Rent_A_Car.MobileAPP.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;

                    //--------------------------------------------------------------------------------

                    //Vodi na kategorije vozila
                    case (int)MenuItemType.Vozila:
                        MenuPages.Add(id, new NavigationPage(new PrikazVozila()));
                        break;

                    case (int)MenuItemType.MojiUgovori:
                        MenuPages.Add(id, new NavigationPage(new UgovorPage()));
                        break;



                    //case (int)MenuItemType.MojiKomentarIOcjene:
                    //    MenuPages.Add(id, new NavigationPage(new OcijenivanjeIKomentarisanje()));
                    //    break;

                    //case (int)MenuItemType.OcijeniIKomentarisi:
                    //    MenuPages.Add(id, new NavigationPage(new DojamPage()));
                    //    break;

                    case (int)MenuItemType.MojeRezervacije:
                        MenuPages.Add(id, new NavigationPage(new RezervacijaVozilaPage()));
                        break;

                    case (int)MenuItemType.ZavrseneRezervacije:
                        MenuPages.Add(id, new NavigationPage(new ZavrsenaRezervacijaPage()));
                        break;

                    case (int)MenuItemType.PostavkeProfila:
                        MenuPages.Add(id, new NavigationPage(new KorisnickiPodaci()));
                        break;


                    case (int)MenuItemType.Odjava:
                        {
                            // clear logirani korsnik
                            MenuPages.Add(id, new NavigationPage(new LoginPage()));
                            break;
                        }
                      
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}