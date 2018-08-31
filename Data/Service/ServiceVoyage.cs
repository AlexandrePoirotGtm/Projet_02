using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;
namespace Data.Service
{
    public class ServiceVoyage
    {
        /// <summary>
        /// méthode pour afficher des instances de la table voyage
        /// </summary>
        public IEnumerable<Voyage> GetVoyages()
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
        public Voyage GetVoyage(int idVoyage)
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
		public void CreerVoyage(Voyage v)
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
		public void EffacerVoyage(int idVoyage)
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
        /// méthode pour voir si une voyage est dans la base. Cherche pour son id.
        /// </summary>
        public bool ChercherVoyage(int idVoyage)
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
        public IEnumerable<Voyage> ChercherVoyageParDestination_Cotinent(string continent)
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
        public IEnumerable<Voyage> ChercherVoyageParDestination_Pays(string pays)
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
        public IEnumerable<Voyage> ChercherVoyageParDestination_Region(string region)
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
        public IEnumerable<Voyage> ChercherVoyageParDate(DateTime aller,DateTime retour)
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
