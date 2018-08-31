using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Data;
using Data.Service;
using Projet_02;

namespace Projet_02.Sous_menus
{
    class SMAfficherDestination : ModuleBase<Application>
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

        private IEnumerable<Destination> liste = new List<Destination>();

        public SMAfficherDestination(Application application, string nomModule)
            : base(application, nomModule)
        {
            
        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Chercher par Continent")
            {
                FonctionAExecuter = this.AfficherDossierContinent
            });
            menu.AjouterElement(new ElementMenu("2", "Chercher par Pays")
            {
                FonctionAExecuter = this.AfficherDossierPays
            });
            menu.AjouterElement(new ElementMenu("3", "Chercher par Region")
            {
                FonctionAExecuter = this.AfficherDossierRegion
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu precedent..."));
        }

        private void AfficherDossierRegion()
        {
            ConsoleHelper.AfficherEntete("Afficher");
            liste = ServiceDestination.FiltrerDestinationRegion(OutilsConsole.PosezQuestion("Region: "));
            ConsoleHelper.AfficherListe(this.liste, strategieAffichageClients);
        }

        private void AfficherDossierPays()
        {
            ConsoleHelper.AfficherEntete("Afficher");
            liste = ServiceDestination.FiltrerDestinationPays(OutilsConsole.PosezQuestion("Pays: "));
            ConsoleHelper.AfficherListe(this.liste, strategieAffichageClients);
        }

        private void AfficherDossierContinent()
        {
            ConsoleHelper.AfficherEntete("Afficher");
            liste = ServiceDestination.FiltrerDestinationContinent(OutilsConsole.PosezQuestion("Continent: "));
            ConsoleHelper.AfficherListe(this.liste, strategieAffichageClients);
        }
    }
}
