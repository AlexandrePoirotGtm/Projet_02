using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02
{
    public class Application : ApplicationBase
    {
        public Application()
            : base("BO Voyage")
        {
            CouleursConsole.Entete = ConsoleColor.DarkYellow;
            CouleursConsole.Saisie = ConsoleColor.DarkCyan;
            CouleursConsole.RetourMenu = ConsoleColor.DarkGreen;
        }

        public MenuVoyages MenuVoyages { get; private set; }
        public MenuDossier MenuDossier { get; private set; }
        public MenuClient MenuClient { get; private set; }
        public MenuAgence MenuAgence { get; private set; }
        public MenuAssurance MenuAssurance { get; private set; }
        public MenuDestination MenuDestination { get; private set; }

        protected override void InitialiserModules()
        {
            this.MenuVoyages = this.AjouterModule(new MenuVoyages(this, "Gerer Voyage"));
            this.MenuDossier = this.AjouterModule(new MenuDossier(this, "Gerer Dossier"));
            this.MenuClient = this.AjouterModule(new MenuClient(this, "Gerer Client"));
            this.MenuAgence = this.AjouterModule(new MenuAgence(this, "Gerer Agence"));
            this.MenuAssurance = this.AjouterModule(new MenuAssurance(this, "Gerer Assurance"));
            this.MenuDestination = this.AjouterModule(new MenuDestination(this, "Gerer Destination"));
        }
    }
}
