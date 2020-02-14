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
    public partial class DiscoveryPage : TabbedPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
        }

        private void TappedMainBar(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = Color.Gold;
            MainCafe.BackgroundColor = Color.White;
            MainFood.BackgroundColor = Color.White;
            MainMeal.BackgroundColor = Color.White;
            MainPizza.BackgroundColor = Color.White;
            MainRoute.BackgroundColor = Color.White;
        }

        private void TappedMainMeal(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = Color.White;
            MainCafe.BackgroundColor = Color.White;
            MainFood.BackgroundColor = Color.White;
            MainMeal.BackgroundColor = Color.Gold;
            MainPizza.BackgroundColor = Color.White;
            MainRoute.BackgroundColor = Color.White;
        }

        private void TappedMainCafe(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = Color.White;
            MainCafe.BackgroundColor = Color.Gold;
            MainFood.BackgroundColor = Color.White;
            MainMeal.BackgroundColor = Color.White;
            MainPizza.BackgroundColor = Color.White;
            MainRoute.BackgroundColor = Color.White;
        }

        private void TappedMainRoute(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = Color.White;
            MainCafe.BackgroundColor = Color.White;
            MainFood.BackgroundColor = Color.White;
            MainMeal.BackgroundColor = Color.White;
            MainPizza.BackgroundColor = Color.White;
            MainRoute.BackgroundColor = Color.Gold;
        }

        private void TappedMainFood(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = Color.White;
            MainCafe.BackgroundColor = Color.White;
            MainFood.BackgroundColor = Color.Gold;
            MainMeal.BackgroundColor = Color.White;
            MainPizza.BackgroundColor = Color.White;
            MainRoute.BackgroundColor = Color.White;
        }

        private void TappedMainPizza(object sender, EventArgs e)
        {
            MainBar.BackgroundColor = Color.White;
            MainCafe.BackgroundColor = Color.White;
            MainFood.BackgroundColor = Color.White;
            MainMeal.BackgroundColor = Color.White;
            MainPizza.BackgroundColor = Color.Gold;
            MainRoute.BackgroundColor = Color.White;

        }
    }
}