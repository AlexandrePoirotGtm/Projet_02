using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02.Sous_menus
{
    class SMAfficherVoyages : ModuleBase<Application>
    {
        public SMAfficherVoyages(Application application, string nomModule)
            : base(application, nomModule)
        {
        }

        protected override void InitialiserMenu(Menu menu)
        {

            menu.AjouterElement(new ElementMenu("1", "Afficher voyages par Agences")
            {
                FonctionAExecuter = this.AfficherParAgences
            });
            menu.AjouterElement(new ElementMenu("2", "Afficher voyages par Destinations")
            {
                FonctionAExecuter = this.AfficherParDestinations
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu precedent..."));

        }

        private void AfficherParAgences()
        {

            ConsoleHelper.AfficherEntete("Afficher Les Agences");


        }

        private void AfficherParDestinations()
        {
            ConsoleHelper.AfficherEntete("Afficher Les Agences");


        }
    }
}
