using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestGrid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new DiscoveryPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
