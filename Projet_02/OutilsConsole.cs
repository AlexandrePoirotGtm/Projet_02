using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02
{
    public static class OutilsConsole
    {

        public static string PosezQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static string PosezQuestionObligatoire(string question)
        {
            string reponse;
            Console.WriteLine(question);
            reponse = Console.ReadLine();
            while (string.IsNullOrEmpty(reponse))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                reponse = Console.ReadLine();
            };
            return reponse;
        }

        public static DateTime PosezDate(string question)
        {
            string reponse;
            DateTime resultat;
            Console.WriteLine(question);
            reponse = Console.ReadLine();
            while (!DateTime.TryParse(reponse ,out resultat))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                reponse = Console.ReadLine();
            };
            return resultat;
        }

        public static decimal PosezPrix(string question)
        {
            string reponse;
            decimal resultat;
            Console.WriteLine(question);
            reponse = Console.ReadLine();
            while (!decimal.TryParse(reponse, out resultat))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                reponse = Console.ReadLine();
            };
            return resultat;
        }

        public static int PosezNombre(string question)
        {
            string reponse;
            int resultat;
            Console.WriteLine(question);
            reponse = Console.ReadLine();
            while (!int.TryParse(reponse, out resultat))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                reponse = Console.ReadLine();
            };
            return resultat;
        }

        public static float PosezReduction(string question)
        {
            string reponse;
            float resultat;
            Console.WriteLine(question);
            reponse = Console.ReadLine();
            while (!float.TryParse(reponse, out resultat))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                reponse = Console.ReadLine();
            };
            return resultat;
        }
    }
}
