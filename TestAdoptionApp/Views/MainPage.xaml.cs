using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestAdoptionApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(bool isLoggedIn)
        {
            InitializeComponent();

            if (!isLoggedIn)
            {
                App.Current.MainPage = new LoginPage();
            }
        }
    }
}
