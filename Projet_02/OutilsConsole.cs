using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using Data;

namespace Projet_02
{
    public static class OutilsConsole
    {

        public static string PosezQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        
        public static TypeAssurance PosezTypeAssurance(string question)
        {
            Console.WriteLine(question);
            string re = Console.ReadLine();
            TypeAssurance typeAssurance;
            while (!(Enum.TryParse(re, true, out typeAssurance)) | (!(Enum.IsDefined(typeof(TypeAssurance), typeAssurance))))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                re = Console.ReadLine();
            };
            return typeAssurance;
        }

        public static Etat PosezEtat(string question)
        {
            Console.WriteLine(question);
            string re = Console.ReadLine();
            Etat etat;
            while (!(Enum.TryParse(re, true, out etat)) | (!(Enum.IsDefined(typeof(Etat), etat))))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                re = Console.ReadLine();
            };
            return etat;
        }

        public static RaisonAnnulationDossier PosezRaisonAnnulation(string question)
        {
            Console.WriteLine(question);
            string re = Console.ReadLine();
            RaisonAnnulationDossier raisonAnnulationDossier;
            while (!(Enum.TryParse(re, true, out raisonAnnulationDossier)) | (!(Enum.IsDefined(typeof(RaisonAnnulationDossier), raisonAnnulationDossier))))
            {
                ConsoleHelper.AfficherMessageErreur("Reponse Obligatoire\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                re = Console.ReadLine();
            };
            return raisonAnnulationDossier;
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
            DateTime datemin = DateTime.Parse("01/01/1753");
            Console.WriteLine(question);
            reponse = Console.ReadLine();


            while ( (!DateTime.TryParse(reponse, out resultat))  | ((resultat.CompareTo(datemin) < 0)) )
               {
                         ConsoleHelper.AfficherMessageErreur("Format incorrect ou date plus trop vieille\nVeuillez Recommancer : ");
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
                ConsoleHelper.AfficherMessageErreur("Format incorrect\nVeuillez Recommancer : ");
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
                ConsoleHelper.AfficherMessageErreur("Format incorrect\nVeuillez Recommancer : ");
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
                ConsoleHelper.AfficherMessageErreur("Format incorrect\nVeuillez Recommancer : ");
                Console.WriteLine(question);
                reponse = Console.ReadLine();
            };
            return resultat;
        }

        public static int CalculerAge(DateTime dateNaissance)
        {
            return (int)((DateTime.Today - dateNaissance).Days / 365.25);
        }

        public static float CalculerPromo(int age)
        {
            if (age > 12)
                return 0;
            else
                return 0.20f;
        }
    }
}
