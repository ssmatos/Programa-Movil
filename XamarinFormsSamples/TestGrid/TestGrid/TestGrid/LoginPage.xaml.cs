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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void PasswordVisibility(object sender, EventArgs e)
        {
            imagePassword.Source = !EntryPass.IsPassword ? "PasswordEye" : "Hide";
            EntryPass.IsPassword = !EntryPass.IsPassword;
        }

        async void HighwayToSignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage(mail.Text));
        }

        async void ConfirmationLog(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mail.Text) || string.IsNullOrEmpty(EntryPass.Text))
            {
                await DisplayAlert("Alert", "Null Entries", "OK");
            }
            else
            {
                await Navigation.PushAsync(new DiscoveryPage());
            }
        }
    }
}