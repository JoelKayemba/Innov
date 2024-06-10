using System;
using System.Collections.Generic;
using System.Text;

namespace InnovAPK.Models
{
    internal class Entreprise : Utilisateur
    {
        // Propriétés spécifiques à l'entreprise
        public string Type { get; set; }
        public string SecteurActivite { get; set; }
        public string SiteWeb { get; set; }

        // Constructeur par défaut
        public Entreprise()
        {
            // Initialisez ou configurez les valeurs par défaut au besoin
        }
    }
}
