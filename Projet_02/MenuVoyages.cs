using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Metier;
using Data;
using Projet_02.Sous_menus;


namespace Projet_02
{
    public class MenuVoyages : ModuleBase<Application>
    {
        // On définit ici les propriétés qu'on veut afficher
        //  et la manière de les afficher
         /*   private static readonly List<InformationAffichage> strategieAffichageClients =
                 new List<InformationAffichage>
                 {
                     InformationAffichage.Creer<Client>(x=>x.Id, "Id", 3),
                     InformationAffichage.Creer<Client>(x=>x.Nom, "Nom", 10),
                     InformationAffichage.Creer<Client>(x=>x.Prenom, "Prenom", 10),
                     InformationAffichage.Creer<Client>(x=>x.Email, "Email", 15),
                     InformationAffichage.Creer<Client>(x=>x.DateInscription, "Date", 10),
                 };

             private readonly List<Client> liste = new List<Client>();
             */
        public MenuVoyages(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher les voyages")
            {
                FonctionAExecuter = this.AfficherVoyages
            });
            menu.AjouterElement(new ElementMenu("2", "Creer un nouveau voyage")
            {
                FonctionAExecuter = this.CreerVoyage
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        private void CreerVoyage()
        {
            Console.WriteLine("Rajout d'un voyage");
        }

        private void AfficherVoyages()
        {

            SMAfficherVoyages SMAfficherVoyages = new SMAfficherVoyages(Application, "Afficher Les Voyages");
            SMAfficherVoyages.Afficher();


        }
    }
}
