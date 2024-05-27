using InnovAPK.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InnovAPK
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ConnexionPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
