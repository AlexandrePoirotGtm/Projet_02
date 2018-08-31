using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Metier;
using Data;
using Data.Service;

namespace Projet_02
{
    public class MenuAgence : ModuleBase<Application>
    {
        private static readonly List<InformationAffichage> strategieAffichageClients =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<AgenceVoyage>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<AgenceVoyage>(x=>x.Nom, "Nom", 20),
            };

        private  IEnumerable<AgenceVoyage> liste = new List<AgenceVoyage>();

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
            menu.AjouterElement(new ElementMenu("2", "Creer une nouvelle agence")
            {
                FonctionAExecuter = this.CreerAgence
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        private void CreerAgence()
        {
            ConsoleHelper.AfficherEntete("Creer Une Agence");
            string nom = OutilsConsole.PosezQuestionObligatoire("Nom : ");
            Services.CreerAgences(nom);
        }

        private void AfficherAgences()
        {
            ConsoleHelper.AfficherEntete("Afficher");
            ServiceAgenceVoyage serviceAgenceVoyage = new ServiceAgenceVoyage();
            liste = serviceAgenceVoyage.GetAgences();
            ConsoleHelper.AfficherListe(this.liste, strategieAffichageClients);
        }
    }
}
