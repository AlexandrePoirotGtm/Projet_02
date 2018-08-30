using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Data;
namespace Projet_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Service.ServiceClient Serv = new Data.Service.ServiceClient();
            Client cli = new Client();
            cli.Adresse = "1 rue des ";
            cli.Civilite = "M";
            cli.Nom = "Doggo";
            cli.Prenom = "George";
            cli.DateNaissance = DateTime.Parse("25/04/1995");
            Serv.CreerClient(cli);
            Console.ReadKey();
            Application Appli = new Application();
            Appli.Demarrer();
        }
    }
}
