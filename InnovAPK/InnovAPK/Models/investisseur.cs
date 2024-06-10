using System;
using System.Collections.Generic;
using System.Text;

namespace InnovAPK.Models
{
    internal class Investisseur : Utilisateur
    {
        // Propriétés spécifiques à l'investisseur
      
        public string Prenom { get; set; }
        // Constructeur par défaut
        public Investisseur()
        {
            // Initialisez ou configurez les valeurs par défaut au besoin
        }
    }
}
