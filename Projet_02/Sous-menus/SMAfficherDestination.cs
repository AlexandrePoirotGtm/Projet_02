using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02.Sous_menus
{
    class SMAfficherDestination : ModuleBase<Application>
    {

        public SMAfficherDestination(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher Destination par Continent")
            {
                FonctionAExecuter = this.AfficherDossierContinent
            });
            menu.AjouterElement(new ElementMenu("2", "Afficher Destination par Pays")
            {
                FonctionAExecuter = this.AfficherDossierPays
            });
            menu.AjouterElement(new ElementMenu("3", "Afficher Destination par Region")
            {
                FonctionAExecuter = this.AfficherDossierRegion
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu precedent..."));
        }

        private void AfficherDossierRegion()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void AfficherDossierPays()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void AfficherDossierContinent()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }
    }
}
