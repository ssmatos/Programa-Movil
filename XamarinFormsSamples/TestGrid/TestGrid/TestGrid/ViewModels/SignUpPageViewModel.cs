using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using TestGrid.Models;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestGrid.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public SignUpPageModel User { get; set; } = new SignUpPageModel();
        public Command VisibilityCommand { get; set; }
        public Command LoginCommand { get; set; }
        public Command ConfirmationSignUp { get; set; }

        public SignUpPageViewModel()
        {
            User.Image = "PasswordEye";
            LoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            });

            ConfirmationSignUp = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.User) || string.IsNullOrEmpty(User.Pass) || string.IsNullOrEmpty(User.Rpass))
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
                User.IsPassword = !User.IsPassword ? true : false;
                if (User.IsPassword)
                {
                    User.Image = "PasswordEye";
                }
                else
                {
                    User.Image = "Hide";
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
