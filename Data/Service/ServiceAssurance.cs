using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;

namespace Data.Service
{
    public static class ServiceAssurance
    {
        /// <summary>
        /// méthode pour afficher des instances de la table Assurance
        /// </summary>
        public static IEnumerable<Assurance> GetAssurance()
        {
            using (var contexte = new Contexte())
            {
                var assurances = (from assu in contexte.Assurances
                               select assu).ToList();
                return assurances;
            }
        }
        /// <summary>
        /// méthode pour afficher une instance de la table Assurance
        /// </summary>
        public static Assurance GetAssurance(int idAssurance)
        {
            using (var contexte = new Contexte())
            {
                var assurance = (from assu in contexte.Assurances
                              where assu.Id == idAssurance
                              select assu).Single();
                return assurance;
            }
        }
        /// <summary>
        /// méthode pour créer une nouvelle instance de Assurance sur la base.
		/// </summary>
		public static void CreerAssurance(Assurance assu)
        {
            using (var contexte = new Contexte())
            {
                contexte.Assurances.Add(assu);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance de Assurance sur la base pour son id.
		/// </summary>
		public static void EffacerAssurance(int idAssurance)
        {
            using (var contexte = new Contexte())
            {
                
                var assurance = (from assu in contexte.Assurances
                              where assu.Id == idAssurance
                              select assu).Single();
                contexte.Assurances.Remove(assurance);
                contexte.SaveChanges();
            }
        }
        /// <summary>
        /// méthode pour Modifier une assurance.
        /// </summary>
        /// <param name="assurance">modification de l'assurance par OBJ</param>
        /// <returns></returns>
        public static void ModifierAssurance(Assurance assurance)
        {
            using (var contexte = new Contexte())
            {
                contexte.Assurances.Attach(assurance);
                contexte.Entry(assurance).State = EntityState.Modified;
                contexte.SaveChanges();

            }
        }
    }
}
