using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;
namespace Data.Service
{
    public class ServiceAgenceVoyage
    {
        /// <summary>
        /// méthode pour afficher des instances de la table AgenceVoyage
        /// </summary>
        public IEnumerable<AgenceVoyage> GetAgences()
        {
            using (var contexte = new Contexte())
            {
                var agences = (from av in contexte.AgenceVoyages
                               select av).ToList();
                return agences;
            }
        }
        /// <summary>
        /// méthode pour afficher une instance de la table AgenceVoyage
        /// </summary>
        public AgenceVoyage GetAgence(int IdAgence)
        {
            using (var contexte = new Contexte())
            {
                var agence = (from av in contexte.AgenceVoyages
                              where av.Id == IdAgence
                              select av).Single();
                return agence;
            }
        }
        /// <summary>
        /// méthode pour créer une nouvelle instance de AgenceVoyages sur la base.
		/// </summary>
		public void CreerAgence(AgenceVoyage ag)
        {
            using (var contexte = new Contexte())
            {
                contexte.AgenceVoyages.Add(ag);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance de AgenceVoyages sur la base pour son id.
		/// </summary>
		public void EffacerAgence(int idAgence)
        {
            using (var contexte = new Contexte())
            {
                var agence = (from ag in contexte.AgenceVoyages
                              where ag.Id == idAgence
                              select ag).Single();
                contexte.AgenceVoyages.Remove(agence);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour voir si un AgenceVoyages est dans la base. Cherche pour son id.
		/// </summary>
		public bool ChercherAgence(int idAgence)
        {
            bool trouver = false;
            using (var contexte = new Contexte())
            {
                var agence = (from ag in contexte.AgenceVoyages
                              where ag.Id == idAgence
                              select ag).Count();
                if (agence != 0) { trouver = true; }
            }
            return trouver;
        }
        /// <summary>
        /// méthode pour afficher une liste de voyage qui sont d'une agence
        /// </summary>
        /// <param name="idAgence">identifiant de l'agence</param>
        /// <returns></returns>
        public IEnumerable<Voyage> GetVoyagesParAgence(int idAgence)
        {
            using(var contexte = new Contexte())
            {
                var voyages = (from ag in contexte.AgenceVoyages
                               where ag.Id == idAgence
                               select ag.Voyages).Single();
                return voyages;
            }
        }
    }
}
