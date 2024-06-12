using InnovAPK.Views;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
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

            MainPage = new NavigationPage(new Views.ConnexionPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios={Your App secret here};" +
                   "uwp={Your UWP App secret here};" +
                   "android={Your Android App secret here};" +
                   "macos={Your macOS App secret here};",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
