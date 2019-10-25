using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestAdoptionApp.Views
{
    public partial class RecoverPasswordEmailPage : ContentPage
    {
        public RecoverPasswordEmailPage()
        {
            InitializeComponent();
        }

        void BackToLoginPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}
