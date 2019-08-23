using System;
using System.ComponentModel;
using System.Windows.Input;
using TestAdoptionApp.Data;
using TestAdoptionApp.Models;
using TestAdoptionApp.Views;
using Xamarin.Forms;

namespace TestAdoptionApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        public Action InvalidLoginWarning;
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SubmitCommand { protected set; get; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private bool isLoggedIn;
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set
            {
                isLoggedIn = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsLoggedIn"));
            }
        }

        async public void OnSubmit()
        {
            User user = new User(Email, Password);
            bool userExists = App.Database.CheckLoginData(user);

            if (userExists)
            {
                IsLoggedIn = true;
                App.Current.MainPage = new MainPage();
            }
            else
            {
                IsLoggedIn = false;
                await Application.Current.MainPage.DisplayAlert("Invalid data", "Please try to login again!", "Ok");
            }
        }

    }
}
