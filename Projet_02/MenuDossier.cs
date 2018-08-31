using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Metier;
using Projet_02.Sous_menus;
using Data;

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

            Console.WriteLine("Reserver pour quelle voyage : ");
            int IdVoyage = Affichage.AfficherListeVoyages();
            Console.Clear();
            Console.WriteLine("Quel Clients : ");
            int IdCLient = Affichage.AfficherListeClients();

            int nombreVoyageurs;

            while ((nombreVoyageurs = OutilsConsole.PosezNombre("Nombre de Voyageurs : ")) > 9);
            List<Participant> participants;
            participants = Affichage.CreerParticpants(nombreVoyageurs);
            string CarteBancaire = OutilsConsole.PosezQuestionObligatoire("Numéro de Carte Bancaire : ");

            Services.CreerDossier(IdVoyage, IdCLient, nombreVoyageurs,participants ,CarteBancaire);
        }

        private void AfficherDossier()
        {
            SMAfficherDossier SMAfficherDossier = new SMAfficherDossier(Application, "Afficher les Dossiers");
            SMAfficherDossier.Afficher();
        }
    }
}
