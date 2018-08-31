using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Metier;
using Data;
using Projet_02.Sous_menus;
using Data.Service;


namespace Projet_02
{
    public class MenuVoyages : ModuleBase<Application>
    {
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
            ConsoleHelper.AfficherEntete("Création d'un voyage");
            
            Console.WriteLine("Ce voyage appartient à quelle Agence : ");
            int IdAgenceVoyage = Affichage.AfficherListeAgences();
            Console.WriteLine("Quel Destination : ");
            int IdDestination = Affichage.AfficherListeDestinations();

            DateTime DateAller = OutilsConsole.PosezDate("Date d'aller : ");
            DateTime DateRetour = OutilsConsole.PosezDate("Date de retour  : ");
            int PlacesDisponibles = OutilsConsole.PosezNombre("Nombres de place disponible  : ");
            decimal PrixParPersonne = OutilsConsole.PosezPrix("Prix Par personne  : ");
            

            

            Services.CreerVoyages(IdAgenceVoyage,IdDestination,DateAller,DateRetour,PlacesDisponibles,PrixParPersonne);
        }

        private void AfficherVoyages()
        {

            SMAfficherVoyages SMAfficherVoyages = new SMAfficherVoyages(Application, "Afficher Les Voyages");
            SMAfficherVoyages.Afficher();


        }
    }
}
