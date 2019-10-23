using System;
using System.Collections.Generic;
using TestAdoptionApp.ViewModels;
using Xamarin.Forms;

namespace TestAdoptionApp.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            var vm = new RegisterViewModel();
            this.BindingContext = vm;
        }

        void BackToLoginPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}
