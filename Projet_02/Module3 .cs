using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Metier;

namespace Projet_02
{
    public class Module3 : ModuleBase<Application>
    {
        // On définit ici les propriétés qu'on veut afficher
        //  et la manière de les afficher
        /*    private static readonly List<InformationAffichage> strategieAffichageClients =
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
        public Module3(Application application, string nomModule)
            : base(application, nomModule)
        {

        }

        protected override void InitialiserMenu(Menu menu)
        {
            menu.AjouterElement(new ElementMenu("1", "Afficher")
            {
                FonctionAExecuter = this.Afficher
            });
            menu.AjouterElement(new ElementMenu("2", "Nouveau")
            {
                FonctionAExecuter = this.Nouveau
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

      /*  private void Afficher()
        {
            ConsoleHelper.AfficherEntete("Afficher");

            ConsoleHelper.AfficherListe(this.liste, strategieAffichageClients);
        }*/

        private void Nouveau()
        {
            ConsoleHelper.AfficherEntete("Nouveau");
        }
    }
}
