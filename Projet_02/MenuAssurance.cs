using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02
{
    public class MenuAssurance : ModuleBase<Application>
    {

        public MenuAssurance(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher toutes les Assurances")
            {
                FonctionAExecuter = this.AfficherAssurance
            });
            menu.AjouterElement(new ElementMenu("2", "Créer une nouvelle assurances")
            {
                FonctionAExecuter = this.CréerAssurances
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        private void CréerAssurances()
        {
            ConsoleHelper.AfficherEntete("Créer une Assurance");
            OutilsConsole.PosezPrix("Montant : ");
            OutilsConsole.PosezQuestionObligatoire("Type D'assurance : ");
        }

        private void AfficherAssurance()
        {
            ConsoleHelper.AfficherEntete("Afficher");
        }
    }

}
