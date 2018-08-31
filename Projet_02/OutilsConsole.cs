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
    }
}
