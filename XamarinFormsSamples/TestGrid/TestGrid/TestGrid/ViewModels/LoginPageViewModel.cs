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
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public string Mail { get; set; }
        public string EntryPass { get; set; }
        public bool IsPassword { get; set; }
        public string Image { get; set; }
        public Command ConfirmLoginCommand { get; set; }
        public Command SignUpCommand { get; set; }
        public Command VisibilityCommand { get; set; }

        public LoginPageViewModel()
        {
            Image = "PasswordEye";
            ConfirmLoginCommand = new Command(async() =>
            {
                if (string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(EntryPass))
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
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage(Mail));
            });

            VisibilityCommand = new Command(() =>
            {
                IsPassword = !IsPassword ? true : false;
                if (IsPassword)
                {
                    Image = "PasswordEye";
                }
                else
                {
                    Image = "Hide";
                }
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
