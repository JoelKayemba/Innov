using System;
using System.Collections.Generic;
using System.Text;

namespace InnovAPK.Models
{
    internal abstract class Utilisateur
    {
        // Propriétés communes à tous les utilisateurs
        public string Nom { get; set; }
        
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string ConfirmationMotDePasse { get; set; }

        // Constructeur par défaut
        protected Utilisateur()
        {
            // Initialisez ou configurez les valeurs par défaut au besoin
        }
    }
}
