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
    internal class EntrepriseViewModel : INotifyPropertyChanged
    {

        private static readonly EntrepriseViewModel _instance = new EntrepriseViewModel();
        public static EntrepriseViewModel Instance { get { return _instance; } }
        private Entreprise _entreprise;

        public ICommand RegisterCommand { get; private set; }
        public Entreprise Entreprise
        {
            get { return _entreprise; }
            set
            {
                if (_entreprise != value)
                {
                    _entreprise = value;
                    OnPropertyChanged();
                }
            }
        }

        public EntrepriseViewModel()
        {
            Entreprise = new Entreprise();
            RegisterCommand = new Command(async () => await ExecuteRegisterCommand());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private async Task ExecuteRegisterCommand()
        {
            // Logique pour traiter l'inscription de l'innovateur

            // Accéder aux valeurs de Nom et Prenom depuis le ViewModel
            string nom = Entreprise.Nom;
            string type = Entreprise.Type;
            string secteur =Entreprise.SecteurActivite;

            // Construire le message de confirmation avec le nom et le prénom
            string confirmationMessage = $"Inscription réussie pour l'entreprise de nom  {nom} de type {type}  et travaillant dans le secteur d'activité {secteur} !";

            // Afficher une alerte de confirmation d'inscription avec le message construit
            await Application.Current.MainPage.DisplayAlert("Confirmation", confirmationMessage, "OK");
        }

    }
}

