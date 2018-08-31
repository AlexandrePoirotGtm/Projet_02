using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02
{
    public class MenuAgence : ModuleBase<Application>
    {

        public MenuAgence(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher toutes les agences")
            {
                FonctionAExecuter = this.AfficherAgences
            });
            menu.AjouterElement(new ElementMenu("2", "Chercher une agences")
            {
                FonctionAExecuter = this.ChercherAgences
            });
            menu.AjouterElement(new ElementMenu("3", "Creer une nouvelle agence")
            {
                FonctionAExecuter = this.CreerAgence
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        private void CreerAgence()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void ChercherAgences()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void AfficherAgences()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }
    }
}
