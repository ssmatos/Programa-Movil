using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestGrid.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public string Email { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Rpass { get; set; }
        public bool IsPassword { get; set; } = true;
        public Command VisibilityCommand { get; set; }
        public Command LoginCommand { get; set; }
        public Command ConfirmationSignUp { get; set; }

        public SignUpPageViewModel()
        {

            LoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            });

            ConfirmationSignUp = new Command(async () =>
            {
                if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(Rpass))
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Null Entries", "OK");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                }
            });
            VisibilityCommand = new Command(() =>
            {
                IsPassword = !IsPassword ? true : false;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
