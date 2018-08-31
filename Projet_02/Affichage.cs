using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Data;
using Data.Service;

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

        private static IEnumerable<Destination> listeDestinations = new List<Destination>();

        public static int AfficherListeDestinations()
        {           
            listeDestinations = ServiceDestination.GetDestinations();
            ConsoleHelper.AfficherListe(listeDestinations, strategieAffichageDestiniations);
            int id;
            do
            {
                id = OutilsConsole.PosezNombre("Tapez l'ID");
            } while (!ServiceDestination.ChercherDestination(id));
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
            ConsoleHelper.AfficherListe(listeClients, strategieAffichageClients);
            return OutilsConsole.PosezNombre("Quel");
        }
        /*public static int AfficherListeVoyages()
        {
            ConsoleHelper.AfficherListe(listeVoyages, strategieAffichageVoyages);
            return OutilsConsole.PosezNombre("rentrez ID:");
        }
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
