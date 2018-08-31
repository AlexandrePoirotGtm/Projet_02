using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Metier;
using Projet_02.Sous_menus;

namespace Projet_02
{
    public class MenuDossier : ModuleBase<Application>
    {

        public MenuDossier(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher Dossiers")
            {
                FonctionAExecuter = this.AfficherDossier
            });
            menu.AjouterElement(new ElementMenu("2", "Créer/Réservation")
            {
                FonctionAExecuter = this.CréerDossier
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        private void CréerDossier()
        {
            ConsoleHelper.AfficherEntete("Création D'un Dossier");
            OutilsConsole.PosezNombre("Nombre de Voyageurs : ");
            //Appelent Création Voyageurs qui va demander les reductions et calculer le prix
            OutilsConsole.PosezQuestionObligatoire("Numéro de Carte Bancaire : ");
        }

        private void AfficherDossier()
        {
            SMAfficherDossier SMAfficherDossier = new SMAfficherDossier(Application, "Afficher les Dossiers");
            SMAfficherDossier.Afficher();
        }
    }
}
