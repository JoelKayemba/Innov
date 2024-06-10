using InnovAPK.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace InnovAPK.ViewsModels
{
    internal class InnovateurViewModel : INotifyPropertyChanged
    {
        private static readonly InnovateurViewModel _instance = new InnovateurViewModel();
        public static InnovateurViewModel Instance { get { return _instance; } }
        private Innovateur _innovateur;
        // Commande pour l'inscription
        public ICommand RegisterCommand { get; private set; }
        public Innovateur Innovateur
        {
            get { return _innovateur; }
            set
            {
                if (_innovateur != value)
                {
                    _innovateur = value;
                    OnPropertyChanged();
                }
            }
        }

        public  InnovateurViewModel()
        {
            Innovateur = new Innovateur();
            // Initialisation de la commande
            // Initialisation de la commande
            RegisterCommand = new Command(async () => await ExecuteRegisterCommand());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Méthode asynchrone pour exécuter la commande d'inscription
        private async Task ExecuteRegisterCommand()
        {
            // Logique pour traiter l'inscription de l'innovateur

            // Accéder aux valeurs de Nom et Prenom depuis le ViewModel
            string nom = Innovateur.Nom;
            string prenom = Innovateur.Prenom;

            // Construire le message de confirmation avec le nom et le prénom
            string confirmationMessage = $"Inscription réussie pour {prenom} {nom} !";

            // Afficher une alerte de confirmation d'inscription avec le message construit
            await Application.Current.MainPage.DisplayAlert("Confirmation", confirmationMessage, "OK");
        }

    }
}