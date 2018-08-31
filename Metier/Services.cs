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
        public static Participant CreerParticpant(string nom, string prenom, string civilite, string adresse, string telephone, DateTime dateNaissance, int age,float reduction)
        {
            Participant participant = new Participant
            {
                Nom = nom,
                Prenom = prenom,
                Civilite = civilite,
                Adresse = adresse,
                Telephone = telephone,
                DateNaissance = dateNaissance,
                Age = age,
                Reduction = reduction,
            };
            return participant;
        }

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

        public static void CreerAssurance(decimal montant, TypeAssurance typeAssurance)
        {
            Assurance assurance = new Assurance
            {
                Montant = montant,
                TypeAssurance = typeAssurance
            };

            ServiceAssurance.CreerAssurance(assurance);
        }

        public static void CreerDestination(string continent, string pays, string region, string description)
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

        public static void CreerVoyages(int idAgenceVoyage, int idDestination, DateTime dateAller, DateTime dateRetour, int placesDisponibles, decimal prixParPersonne)
        {
            Voyage voyage = new Voyage
            {
                DateAller = dateAller,
                DateRetour = dateRetour,
                PlacesDisponibles = placesDisponibles,
                PrixParPersonne = prixParPersonne,
                IdAgenceVoyage = idAgenceVoyage,
                IdDestination = idDestination,
            };
            ServiceVoyage.CreerVoyage(voyage);
            ServiceDestination.GetDestination(idDestination).Voyages.Add(voyage);
        }

        public static void CreerDossier(int idVoyage, int idCLient, int nombreVoyageurs,List<Participant> participants, string carteBancaire)
        {
            DossierReservation dossier = new DossierReservation
            {
                IdVoyage = idVoyage,
                IdClient = idCLient,
                NumeroCarteBancaire = carteBancaire,
            };

            ServiceDossierReservation.CreerDossierReservation(dossier);
            int idDos = dossier.Id;
            foreach (Participant  par in participants)
            {
                ServiceParticipant.CreerParticipant(par,idDos);
            }
            
        }
    }
}
