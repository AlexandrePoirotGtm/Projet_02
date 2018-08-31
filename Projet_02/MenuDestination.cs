using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Projet_02.Sous_menus;
using Metier;
using Data;
using Data.Service;

namespace Projet_02
{
    public class MenuDestination : ModuleBase<Application>
    {
        private static readonly List<InformationAffichage> strategieAffichageClients =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Destination>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Destination>(x=>x.Continent, "Continent", 20),
                InformationAffichage.Creer<Destination>(x=>x.Pays, "Pays", 15),
                InformationAffichage.Creer<Destination>(x=>x.Region, "Region", 20),
                InformationAffichage.Creer<Destination>(x=>x.Description, "Description", 50),
            };

        private  IEnumerable<Destination> liste = new List<Destination>();

        public MenuDestination(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher toutes les Destinations")
            {
                FonctionAExecuter = this.AfficherDestinations
            });
            menu.AjouterElement(new ElementMenu("2", "Chercher une destination")
            {
                FonctionAExecuter = this.ChercherDestination
            });
            menu.AjouterElement(new ElementMenu("3", "Creer une nouvelle Destination")
            {
                FonctionAExecuter = this.CreerDestination
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        private void CreerDestination()
        {
            ConsoleHelper.AfficherEntete("Créer une Destination");
            string continent = OutilsConsole.PosezQuestionObligatoire("Continent : ");
            string pays =  OutilsConsole.PosezQuestionObligatoire("Pays : ");
            string region = OutilsConsole.PosezQuestionObligatoire("Region : ");
            string description = OutilsConsole.PosezQuestionObligatoire("Description : ");

            Services.CreerDestination(continent,pays,region,description);
        }

        private void ChercherDestination()
        {
            SMAfficherDestination sMAfficherDestination = new SMAfficherDestination(Application, "Chercher Destination");
            sMAfficherDestination.Afficher();
            
        }

        private void AfficherDestinations()
        {
            liste = ServiceDestination.GetDestinations();
            ConsoleHelper.AfficherListe(this.liste, strategieAffichageClients);
        }
    }
}
