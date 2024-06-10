using System;
using System.Collections.Generic;
using System.Text;

namespace InnovAPK.Models
{
    internal class Innovateur : Utilisateur
    {
        // Propriétés spécifiques à l'innovateur
        public string Domaine { get; set; }
        public string Prenom { get; set; }
        // Constructeur par défaut
        public Innovateur()
        {
            // Initialisez ou configurez les valeurs par défaut au besoin
        }
    }
}
