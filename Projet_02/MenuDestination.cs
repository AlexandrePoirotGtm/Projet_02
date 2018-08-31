using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02
{
    public class MenuDestination : ModuleBase<Application>
    {

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
            menu.AjouterElement(new ElementMenu("2", "Chercher une agences")
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
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void ChercherDestination()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void AfficherDestinations()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }
    }
}
