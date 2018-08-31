using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02.Sous_menus
{
    class SMAfficherClient : ModuleBase<Application>
    {
        public SMAfficherClient(Application application, string nomModule)
            : base(application, nomModule)
        {
        }

        protected override void InitialiserMenu(Menu menu)
        {

            menu.AjouterElement(new ElementMenu("1", "Afficher les client par Nom")
            {
                FonctionAExecuter = this.AfficherNom
            });
            menu.AjouterElement(new ElementMenu("2", "Afficher les client par Prenom")
            {
                FonctionAExecuter = this.AfficherPrenom
            });      
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu precedent..."));
        }

        private void AfficherPrenom()
        {
            Console.WriteLine("clients");
        }

        private void AfficherNom()
        {
            Console.WriteLine("clients");
        }

        private void CreerClient()
        {
            Console.WriteLine("client crée");
        }
    }
}
