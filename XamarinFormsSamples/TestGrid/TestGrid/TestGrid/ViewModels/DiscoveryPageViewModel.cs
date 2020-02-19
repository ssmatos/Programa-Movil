using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Threading.Tasks;
using TestGrid.Models;
using System.ComponentModel;

namespace TestGrid.ViewModels
{
    class DiscoveryPageViewModel : INotifyPropertyChanged
    
    {
        public MenuElements BarElemets { get; set; } = new MenuElements();
        public MenuElements DinnerElemets { get; set; } = new MenuElements();
        public MenuElements CafeElemets { get; set; } = new MenuElements();

        public MenuElements MapElemets { get; set; } = new MenuElements();
        public MenuElements FfoodElemets { get; set; } = new MenuElements();
        public MenuElements NfoodElemets { get; set; } = new MenuElements();

        public Command ColorChangeCommand { get; set;}

        public DiscoveryPageViewModel()
        {

            BarElemets.Title = "Bar & Hotels";
            BarElemets.SubTitle = "42 Places";
            BarElemets.ImageSource = "icons8beer96";

            DinnerElemets.Title = "Fine Dining";
            DinnerElemets.SubTitle = "15 Places";
            DinnerElemets.ImageSource = "icons8meal64";

            CafeElemets.Title = "Cafes";
            CafeElemets.SubTitle = "28 Places";
            CafeElemets.ImageSource = "icons8cafe64";

            MapElemets.Title = "Nearby";
            MapElemets.SubTitle = "34 Places";
            MapElemets.ImageSource = "Nearby";

            FfoodElemets.Title = "Fast Foods";
            FfoodElemets.SubTitle = "29 Places";
            FfoodElemets.ImageSource = "FastFood";

            NfoodElemets.Title = "Featured Food";
            NfoodElemets.SubTitle = "21 Places";
            NfoodElemets.ImageSource = "Pizza";

            ColorChangeCommand = new Command(() =>
           {
               
           });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
