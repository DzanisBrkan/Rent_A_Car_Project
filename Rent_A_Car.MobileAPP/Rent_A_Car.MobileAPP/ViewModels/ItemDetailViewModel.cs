using System;

using Rent_A_Car.MobileAPP.Models;

namespace Rent_A_Car.MobileAPP.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
