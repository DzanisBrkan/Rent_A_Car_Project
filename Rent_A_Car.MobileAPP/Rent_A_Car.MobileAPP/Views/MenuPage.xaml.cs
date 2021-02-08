using Rent_A_Car.MobileAPP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rent_A_Car.MobileAPP.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Pretraga vozila" },
                new HomeMenuItem {Id = MenuItemType.Vozila, Title="Pregled kategorija vozila" },
                new HomeMenuItem {Id = MenuItemType.MojiUgovori, Title="Izdati računi" },
                new HomeMenuItem {Id = MenuItemType.MojeRezervacije, Title="Aktivne rezervacije" },
                new HomeMenuItem {Id=MenuItemType.ZavrseneRezervacije, Title="Završene rezervacije"},
                //new HomeMenuItem {Id = MenuItemType.MojiKomentarIOcjene, Title="Moji komentari i ocijene" },
                //new HomeMenuItem {Id = MenuItemType.OcijeniIKomentarisi, Title="Ocijeni i komentarisi" },
                new HomeMenuItem {Id = MenuItemType.PostavkeProfila, Title="Postavke profila" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjavi se" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}