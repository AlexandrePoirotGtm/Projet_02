using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Data;
using Data.Service;
using Metier;

namespace Projet_02
{
    public class Affichage
    {
        private static readonly List<InformationAffichage> strategieAffichageClients =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Client>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Client>(x=>x.Nom, "Nom", 10),
                InformationAffichage.Creer<Client>(x=>x.Prenom, "Prenom", 15),
                InformationAffichage.Creer<Client>(x=>x.Email, "Email", 20),
                InformationAffichage.Creer<Client>(x=>x.DateNaissance, "Date", 10),
                InformationAffichage.Creer<Client>(x=>x.Adresse, "Adresse", 30),
                InformationAffichage.Creer<Client>(x=>x.Telephone, "Telephone", 11),
            };

        private static IEnumerable<Client> listeClients = new List<Client>();

        private static readonly List<InformationAffichage> strategieAffichageAgences =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<AgenceVoyage>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<AgenceVoyage>(x=>x.Nom, "Nom", 20),
           };

        private static IEnumerable<AgenceVoyage> listeAgences = new List<AgenceVoyage>();

        private static readonly List<InformationAffichage> strategieAffichageDestiniations =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Destination>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Destination>(x=>x.Continent, "Continent", 20),
                InformationAffichage.Creer<Destination>(x=>x.Pays, "Pays", 15),
                InformationAffichage.Creer<Destination>(x=>x.Region, "Region", 20),
                InformationAffichage.Creer<Destination>(x=>x.Description, "Description", 50),
            };

        internal static List<Participant> CreerParticpants(int nombreParticipants)
        {
            List<Participant> Participants = new List<Participant>();
            for (int i = 0; i < nombreParticipants; i++)
            {
                ConsoleHelper.AfficherEntete("Creer un Participant");
                string nom = OutilsConsole.PosezQuestionObligatoire("Nom : ");
                string prenom = OutilsConsole.PosezQuestionObligatoire("Prenom : ");
                string civilite = OutilsConsole.PosezQuestionObligatoire("Civilité : ");
                string adresse = OutilsConsole.PosezQuestionObligatoire("Adresse : ");
                string telephone = OutilsConsole.PosezQuestionObligatoire("Telephone : ");
                DateTime dateNaissance = OutilsConsole.PosezDate("Date de Naissance : ");
                string email = OutilsConsole.PosezQuestion("Email :");
                int age = OutilsConsole.CalculerAge(dateNaissance);
                
                Participants.Add(Services.CreerParticpant(nom, prenom, civilite, adresse, telephone, dateNaissance, age, OutilsConsole.CalculerPromo(age)));
            }
            return Participants;
        }

        private static IEnumerable<Destination> listeDestinations = new List<Destination>();

        private static readonly List<InformationAffichage> strategieAffichageVoyages =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Voyage>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Voyage>(x=>x.DateAller, "DateAller", 15),
                InformationAffichage.Creer<Voyage>(x=>x.DateRetour, "DateRetour", 15),
                InformationAffichage.Creer<Voyage>(x=>x.PlacesDisponibles, "Places", 3),
                InformationAffichage.Creer<Voyage>(x=>x.PrixParPersonne, "Prix/Personne", 5),
            };

        private static IEnumerable<Voyage> listeVoyages = new List<Voyage>();

        public static int AfficherListeDestinations()
        {
            listeDestinations = ServiceDestination.GetDestinations();
            ConsoleHelper.AfficherListe(listeDestinations, strategieAffichageVoyages);
            int id;
            do
            {
                id = OutilsConsole.PosezNombre("Tapez l'ID");
            } while (!ServiceDestination.ChercherDestination(id));
            return id;
        }

        public static int AfficherListeVoyages()
        {           
            listeVoyages = ServiceVoyage.GetVoyages();
            ConsoleHelper.AfficherListe(listeVoyages, strategieAffichageVoyages);
            int id;
            do
            {
                id = OutilsConsole.PosezNombre("Tapez l'ID");
            } while (!ServiceVoyage.ChercherVoyage(id));
            return id;
        }

        public static int AfficherListeAgences()
        {
            listeAgences = ServiceAgenceVoyage.GetAgences();
            ConsoleHelper.AfficherListe(listeAgences,strategieAffichageAgences);
            int id;
            do
            {
                id = OutilsConsole.PosezNombre("Tapez l'ID");
            } while (!ServiceAgenceVoyage.ChercherAgence(id));
            return id;
        }

        public static int AfficherListeClients()
        {
            listeClients = ServiceClient.GetClients();
            ConsoleHelper.AfficherListe(listeClients, strategieAffichageClients);
            int id;
            do
            {
                id = OutilsConsole.PosezNombre("Tapez l'ID");
            } while (!ServiceClient.ChercherClient(id));
            return id;
        }
/*
        public static int AfficherListeDossiers()
        {
            ConsoleHelper.AfficherListe(ListeDossiers, strategieAffichageDossiers);
            return OutilsConsole.PosezNombre("rentrez ID:");
        }
        public static int AfficherListeAssurances()
        {
            ConsoleHelper.AfficherListe(listeAssurances, strategieAffichageAssurances);
            return OutilsConsole.PosezNombre("rentrez ID:");
        }*/

    }
}
