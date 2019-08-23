using System;
using System.ComponentModel;
using System.Windows.Input;
using TestAdoptionApp.Models;
using TestAdoptionApp.Views;
using Xamarin.Forms;

namespace TestAdoptionApp.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Action InvalidRegisterAttemptWarning;
        public ICommand SubmitCommand { protected set; get; }

        public RegisterViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
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
            User user = new User(Name, Email, Password);
            App.Database.SaveUser(user);

            IsLoggedIn = true;
            await Application.Current.MainPage.DisplayAlert("Success!", "You have an account!", "Ok");

            App.Current.MainPage = new MainPage(IsLoggedIn);

        }

    }
}
