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
    public partial class TransitionPage : ContentPage
    {
        public TransitionPage()
        {
            InitializeComponent();
        }
        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            
            if (innovateurRadioButton.IsChecked)
            {
                await Navigation.PushAsync(new InscriptionInnovateurPage());
            }
            else if (entrepriseRadioButton.IsChecked)
            {
                await Navigation.PushAsync(new InscriptionEntreprisePage());
            }
            else if (ongRadioButton.IsChecked)
            {
                await Navigation.PushAsync(new InscriptionONGPage());
            }
            else if (investisseurRadioButton.IsChecked)
            {
                await Navigation.PushAsync(new InscriptionInnovateurPage());
            }
        }
    }
}