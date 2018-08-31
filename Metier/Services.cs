using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Service;
using Data;
namespace Metier
{
    public static class Services
    {
        //Methodes De cration
        public static void CreerClient(string nom, string prenom, string civilite, string adresse, string telephone, DateTime dateNaissance, string email)
        {
            Client cli = new Client
            {
                Nom = nom,
                Prenom = prenom,
                Civilite = civilite,
                Adresse = adresse,
                Telephone = telephone,
                DateNaissance = dateNaissance,
                Email = email
            };

            ServiceClient.CreerClient(cli);
        }

        public static void CreerAssurance(decimal montant,TypeAssurance typeAssurance)
        {
            Assurance assurance = new Assurance
            {
                Montant = montant,
                TypeAssurance = typeAssurance
            };

            ServiceAssurance.CreerAssurance(assurance);
        }

        public static void CreerDestination(string continent,string pays, string region, string description)
        {
            Destination destination = new Destination
            {
                Continent = continent,
                Pays = pays,
                Region = region,
                Description = description
            };

            ServiceDestination.CreerDestination(destination);
        }

        public static void CreerAgences(string nom)
        {
            AgenceVoyage agenceVoyage = new AgenceVoyage
            {
                Nom = nom
            };
            ServiceAgenceVoyage.CreerAgence(agenceVoyage);
        }
    
        public static void CreerVoyages()
        {
            
        }

     
    }
}
