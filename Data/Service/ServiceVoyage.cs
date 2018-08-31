using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;
namespace Data.Service
{
    public static class ServiceVoyage
    {
        /// <summary>
        /// méthode pour afficher des instances de la table voyage
        /// </summary>
        public static IEnumerable<Voyage> GetVoyages()
        {
            using (var contexte = new Contexte())
            {
                var voyages = (from v in contexte.Voyages
                               select v).ToList();
                return voyages;
            }
        }
        /// <summary>
        /// méthode pour afficher des instances de la table voyage
        /// </summary>
        public static Voyage GetVoyage(int idVoyage)
        {
            using (var contexte = new Contexte())
            {
                var voyages = (from v in contexte.Voyages
                              where v.Id == idVoyage
                              select v).Single();
                return voyages;
            }
        }

        /// <summary>
        /// méthode pour créer une nouvelle instance de voyage sur la base.
		/// </summary>
		public static void CreerVoyage(Voyage v)
        {
            using (var contexte = new Contexte())
            {
                contexte.Voyages.Add(v);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance de voyage sur la base pour son id.
		/// </summary>
		public static void EffacerVoyage(int idVoyage)
        {
            using (var contexte = new Contexte())
            {
                var voyage = (from v in contexte.Voyages
                              where v.Id == idVoyage
                              select v).Single();
                contexte.Voyages.Remove(voyage);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance de voyage sur la base pour son OBJ.
		/// </summary>
		public static void EffacerVoyage(Voyage voyage)
        {
            using (var contexte = new Contexte())
            {
                contexte.Entry(voyage).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour modifier une instance de voyage sur la base pour son OBJ.
		/// </summary>
		public static void ModifierVoyage(Voyage voyage)
        {
            using (var contexte = new Contexte())
            {
                contexte.Voyages.Attach(voyage);
                contexte.Entry(voyage).State = EntityState.Modified;
                contexte.SaveChanges();
            }
        }

        /// <summary>
        /// méthode pour voir si une voyage est dans la base. Cherche pour son id.
        /// </summary>
        public static bool ChercherVoyage(int idVoyage)
        {
            bool trouver = false;
            using (var contexte = new Contexte())
            {
                var voyage = (from c in contexte.Voyages
                              where c.Id == idVoyage
                              select c).Count();
                if (voyage != 0) { trouver = true; }
            }
            return trouver;
        }
        /// <summary>
        /// methode pour chercher de voyage par destination - cotinent.
        /// </summary>
        /// <param name="continent"> cotinent de recherche</param>
        /// <returns>liste des voyages</returns>
        public static IEnumerable<Voyage> ChercherVoyageParDestination_Continent(string continent)
        {
            
            using (var contexte = new Contexte())
            {
                var voyages = (from v in contexte.Voyages
                              where v.Destination.Continent == continent
                               select v).ToList();
                return voyages;
            }
            
        }
        /// <summary>
        /// methode pour chercher de voyage par destination - pays.
        /// </summary>
        /// <param name="pays">pays de recherche</param>
        /// <returns>liste des voyages</returns>
        public static IEnumerable<Voyage> ChercherVoyageParDestination_Pays(string pays)
        {

            using (var contexte = new Contexte())
            {
                var voyages = (from v in contexte.Voyages
                               where v.Destination.Pays == pays
                               select v).ToList();
                return voyages;
            }

        }
        /// <summary>
        /// methode pour chercher de voyage par destination - region.
        /// </summary>
        /// <param name="region">region de recherche</param>
        /// <returns>liste des voyages</returns>
        public static IEnumerable<Voyage> ChercherVoyageParDestination_Region(string region)
        {
            using (var contexte = new Contexte())
            {
                var voyages = (from v in contexte.Voyages
                               where v.Destination.Region == region
                               select v).ToList();
                return voyages;
            }
        }
        /// <summary>
        /// methode pour chercher de voyage par date aller et retour.
        /// </summary>
        /// <param name="aller">date de aller</param>
        /// <param name="retour">date de aller</param>
        /// <returns>liste des voyages</returns>
        public static IEnumerable<Voyage> ChercherVoyageParDate(DateTime aller,DateTime retour)
        {
            using (var contexte = new Contexte())
            {
                var voyages = (from v in contexte.Voyages
                               where v.DateAller >= aller && v.DateRetour <= retour
                               select v).ToList();
                return voyages;
            }
        }

    }
}
