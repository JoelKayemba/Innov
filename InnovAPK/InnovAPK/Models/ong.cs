using System;
using System.Collections.Generic;
using System.Text;

namespace InnovAPK.Models
{
    internal class ONG : Utilisateur
    {
        // Propriété spécifique à l'ONG
        public string Type { get; set; }
        public string Adresse { get; set; }

        // Constructeur par défaut
        public ONG()
        {
            // Initialisez ou configurez les valeurs par défaut au besoin
        }
    }
}
