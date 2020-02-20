using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGrid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel();
        }

        //async void highwayToLogin(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new LoginPage());
        //}

        //async void ConfimationSignUp(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(User.Text) || string.IsNullOrEmpty(Pass.Text) || string.IsNullOrEmpty(Rpass.Text))
        //    {
        //        await DisplayAlert("Alert", "Null Entries", "OK");
        //    }
        //    else
        //    {
        //        await Navigation.PushAsync(new LoginPage());
        //    }
        //}

        //private void PasswordVisibilitySign(object sender, EventArgs e)
        //{
        //    PassImage.Source = !Pass.IsPassword ? "PasswordEye" : "Hide";
        //    Pass.IsPassword = !Pass.IsPassword;
        //}

        //private void PasswordVisibilitySignR(object sender, EventArgs e)
        //{
        //    PassImage2.Source = !Rpass.IsPassword ? "PasswordEye" : "Hide";
        //    Rpass.IsPassword = !Rpass.IsPassword;
        //}
    }
}