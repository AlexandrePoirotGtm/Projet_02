using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Data;
using Data.Service;

namespace Projet_02.Sous_menus
{
    class SMAfficherClient : ModuleBase<Application>
    {
        private static readonly List<InformationAffichage> strategieAffichageClients =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Client>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Client>(x=>x.Nom, "Nom", 10),
                InformationAffichage.Creer<Client>(x=>x.Prenom, "Prenom", 10),
                InformationAffichage.Creer<Client>(x=>x.Email, "Email", 15),
                InformationAffichage.Creer<Client>(x=>x.DateNaissance, "Date", 10),
            };

        private readonly IEnumerable<Client> liste = new List<Client>();

        public SMAfficherClient(Application application, string nomModule)
            : base(application, nomModule)
        {
            ServiceClient serviceClient = new ServiceClient();
            liste = serviceClient.GetClients();
        }

        protected override void InitialiserMenu(Menu menu)
        {

            menu.AjouterElement(new ElementMenu("1", "Afficher les client par Nom")
            {
                FonctionAExecuter = this.AfficherNom
            });
            menu.AjouterElement(new ElementMenu("2", "Afficher les client par Prenom")
            {
                FonctionAExecuter = this.AfficherPrenom
            });      
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu precedent..."));
        }

        private void AfficherPrenom()
        {
            ConsoleHelper.AfficherListe(this.liste, strategieAffichageClients);
        }

        private void AfficherNom()
        {
            Console.WriteLine("clients");
        }

        private void CreerClient()
        {
            Console.WriteLine("client crée");
        }
    }
}
