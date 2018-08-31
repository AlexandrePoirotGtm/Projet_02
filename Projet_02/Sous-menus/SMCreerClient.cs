﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02.Sous_menus
{
    class SMCreerClient : ModuleBase<Application>
    {
        public SMCreerClient(Application application, string nomModule)
            : base(application, nomModule)
        {
        }

        protected override void InitialiserMenu(Menu menu)
        {

            menu.AjouterElement(new ElementMenu("1", "Creer un Client")
            {
                FonctionAExecuter = this.CreerClient
            });
            menu.AjouterElement(new ElementMenu("2", "Chercher un client")
            {
                FonctionAExecuter = this.CreerClient
            });
            menu.AjouterElement(new ElementMenu("3", "Afficher Tout les clients")
            {
                FonctionAExecuter = this.CreerClient
            });
            menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
            menu.AjouterElement(new ElementMenuQuitterMenu("",""));
        }

        private void CreerClient()
        {
            Console.WriteLine("client crée");
        }
    }
}