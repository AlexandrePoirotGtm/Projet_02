using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Metier;
using Projet_02.Sous_menus;
using Data.Service;
using Data;

namespace Projet_02
{
    public class MenuClient : ModuleBase<Application>
    {
        // On définit ici les propriétés qu'on veut afficher
        //  et la manière de les afficher
        /*    private static readonly List<InformationAffichage> strategieAffichageClients =
                 new List<InformationAffichage>
                 {
                     InformationAffichage.Creer<Client>(x=>x.Id, "Id", 3),
                     InformationAffichage.Creer<Client>(x=>x.Nom, "Nom", 10),
                     InformationAffichage.Creer<Client>(x=>x.Prenom, "Prenom", 10),
                     InformationAffichage.Creer<Client>(x=>x.Email, "Email", 15),
                     InformationAffichage.Creer<Client>(x=>x.DateInscription, "Date", 10),
                 };

             private readonly List<Client> liste = new List<Client>();
             */


        public MenuClient(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Creer un Client")
            {
                FonctionAExecuter = this.CreerClient
            });
            menu.AjouterElement(new ElementMenu("2", "Chercher un client")
            {
                FonctionAExecuter = this.ChercherClient
            });
            menu.AjouterElement(new ElementMenu("3", "Afficher Tout les clients")
            {
                FonctionAExecuter = this.AfficherToutClient
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        private void AfficherToutClient()
        {
            SMAfficherClient SMAfficherClient = new SMAfficherClient(Application, "Creer Client");
            SMAfficherClient.Afficher();
        }

        private void ChercherClient()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void CreerClient()
        {
            
            ConsoleHelper.AfficherEntete("Creer un client");
            string nom = OutilsConsole.PosezQuestionObligatoire("Nom : ");
            string prenom = OutilsConsole.PosezQuestionObligatoire("Prenom : ");
            string civilite = OutilsConsole.PosezQuestionObligatoire("Civilité : ");
            string adresse = OutilsConsole.PosezQuestionObligatoire("Adresse : ");
            string telephone = OutilsConsole.PosezQuestionObligatoire("Telephone : ");
            DateTime dateNaissance = OutilsConsole.PosezDate("Date de Naissance : ");
            string email = OutilsConsole.PosezQuestion("Email :");

            Services.CreerClient(nom,prenom,civilite,adresse,telephone,dateNaissance,email);
            

        }
    }
}
