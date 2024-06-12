using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InnovAPK.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnexionPage : ContentPage
    {
        public ConnexionPage()
        {
            InitializeComponent();
            
        }
        private async void OnSignUpTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransitionPage());
        }
    }
}