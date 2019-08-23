using System;
using System.IO;
using TestAdoptionApp.Data;
using TestAdoptionApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAdoptionApp
{
    public partial class App : Application
    {
        static AppDbContext database;
        public static AppDbContext Database
        {
            get
            {
                if(database == null)
                {                  
                    database = new AppDbContext(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "User.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
