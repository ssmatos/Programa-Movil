﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string Mail = "")
        {
            InitializeComponent();
            Email.Text = Mail;
        }

        async void highwayToLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        async void ConfimationSignUp(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(User.Text) || string.IsNullOrEmpty(Pass.Text) || string.IsNullOrEmpty(Rpass.Text))
            {
                await DisplayAlert("Alert", "Null Entries", "OK");
            }
        }
    }
}