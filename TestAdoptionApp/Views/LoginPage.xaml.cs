using System;
using System.Collections.Generic;
using TestAdoptionApp.ViewModels;
using Xamarin.Forms;

namespace TestAdoptionApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            var vm = new LoginViewModel();
            this.BindingContext = vm;

            vm.InvalidLoginWarning += () => DisplayAlert("Error", "Invalid Login, please try again!", "Ok");
        }

        async void OpenRegisterPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegisterPage();
            //await Navigation.PushModalAsync(new RegisterPage());
        }

        async void OpenRecoverPasswordPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new RecoverPasswordEmailPage();
            //await Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
