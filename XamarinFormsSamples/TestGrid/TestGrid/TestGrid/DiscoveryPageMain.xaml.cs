using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPageMain : ContentPage
    {
        public DiscoveryPageMain()
        {
            InitializeComponent();
        }
        private void TappedMainBar(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = Color.Gold;
            MainCafe.BackgroundColor = default;
            MainFood.BackgroundColor = default;
            MainMeal.BackgroundColor = default;
            MainPizza.BackgroundColor = default;
            MainRoute.BackgroundColor = default;
        }

        private void TappedMainMeal(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = default;
            MainCafe.BackgroundColor = default;
            MainFood.BackgroundColor = default;
            MainMeal.BackgroundColor = Color.Gold;
            MainPizza.BackgroundColor = default;
            MainRoute.BackgroundColor = default;
        }

        private void TappedMainCafe(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = default;
            MainCafe.BackgroundColor = Color.Gold;
            MainFood.BackgroundColor = default;
            MainMeal.BackgroundColor = default;
            MainPizza.BackgroundColor = default;
            MainRoute.BackgroundColor = default;
        }

        private void TappedMainRoute(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = default;
            MainCafe.BackgroundColor = default;
            MainFood.BackgroundColor = default;
            MainMeal.BackgroundColor = default;
            MainPizza.BackgroundColor = default;
            MainRoute.BackgroundColor = Color.Gold;
        }

        private void TappedMainFood(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = default;
            MainCafe.BackgroundColor = default;
            MainFood.BackgroundColor = Color.Gold;
            MainMeal.BackgroundColor = default;
            MainPizza.BackgroundColor = default;
            MainRoute.BackgroundColor = default;
        }

        private void TappedMainPizza(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = default;
            MainCafe.BackgroundColor = default;
            MainFood.BackgroundColor = default;
            MainMeal.BackgroundColor = default;
            MainPizza.BackgroundColor = Color.Gold;
            MainRoute.BackgroundColor = default;

        }
    }
}