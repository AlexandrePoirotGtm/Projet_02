using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02.Sous_menus
{
    class SMAfficherDossier : ModuleBase<Application>
    {

        public SMAfficherDossier(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher Dossier Par Numéro de dossier")
            {
                FonctionAExecuter = this.AfficherParNum
            });
            menu.AjouterElement(new ElementMenu("2", "Afficher Dossier par Clients")
            {
                FonctionAExecuter = this.AfficherParClients
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu precedent..."));
        }

        private void AfficherParNum()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }

        private void AfficherParClients()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }
    }
}
