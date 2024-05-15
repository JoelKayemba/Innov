using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InnovAPK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnInscriptionTapped(object sender, EventArgs e)
        {
            // Naviguer vers la page d'inscription
            await Navigation.PushAsync(new PageInscription());
        }

        private async void OnMotDePasseOublieTapped(object sender, EventArgs e)
        {
            // Afficher une boîte de dialogue pour la récupération du mot de passe
            await DisplayAlert("Mot de passe oublié", "Veuillez saisir votre adresse e-mail pour la récupération du mot de passe.", "OK");
            // Naviguer vers la page d'inscription
            await Navigation.PushAsync(new PageMotDePasseOublié());
        }
    }
}
