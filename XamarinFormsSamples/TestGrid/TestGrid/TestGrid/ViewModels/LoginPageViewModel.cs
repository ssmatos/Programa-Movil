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
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public LoginPageModel Username { get; set; } = new LoginPageModel();
        public Command ConfirmLoginCommand { get; set; }
        public Command SignUpCommand { get; set; }
        public Command VisibilityCommand { get; set; }

        public LoginPageViewModel()
        {
            Username.Image = "PasswordEye";
            ConfirmLoginCommand = new Command(async() =>
            {
                if (string.IsNullOrEmpty(Username.Mail) || string.IsNullOrEmpty(Username.EntryPass))
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Null Entries", "OK");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new DiscoveryPage());
                }
            });

            SignUpCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            });

            VisibilityCommand = new Command(() =>
            {
                Username.IsPassword = !Username.IsPassword ? true : false;
                if (Username.IsPassword)
                {
                    Username.Image = "PasswordEye";
                }
                else
                {
                    Username.Image = "Hide";
                }
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
