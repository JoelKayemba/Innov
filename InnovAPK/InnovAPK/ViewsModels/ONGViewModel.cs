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
    internal class ONGViewModel : INotifyPropertyChanged
    {
        private static readonly ONGViewModel _instance = new ONGViewModel();
        public static ONGViewModel Instance { get { return _instance; } }
        private ONG _ong;
        public ICommand RegisterCommand { get; private set; }

        public ONG ONG
        {
            get { return _ong; }
            set
            {
                if (_ong != value)
                {
                    _ong = value;
                    OnPropertyChanged();
                }
            }
        }

        public ONGViewModel()
        {
            ONG = new ONG();
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
            string nom = ONG.Nom;
            string type = ONG.Type;
            


            // Construire le message de confirmation avec le nom et le prénom
            string confirmationMessage = $"Inscription réussie pour l'ONG {nom} et de type {type}   !";

            // Afficher une alerte de confirmation d'inscription avec le message construit
            await Application.Current.MainPage.DisplayAlert("Confirmation", confirmationMessage, "OK");
        }
    }
}
