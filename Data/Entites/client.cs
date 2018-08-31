﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Client : Personne
    {
        public Client()
        {
        }
        public Client(string civ, string nom, string prenom, string adresse,string tel,DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Civilite = civ;
            Telephone = tel;
            DateNaissance = dateNaissance;
        }
        public string Email { get; set; }
        public List<DossierReservation> Dossiers { get; set; }
        //SA MARCHE - CRIS
        public override string ToString()
        {
            return $"({Id}) {Nom.ToUpper()},{Prenom.ToLower()} - Ad. {Adresse}";
        }
    }
}
