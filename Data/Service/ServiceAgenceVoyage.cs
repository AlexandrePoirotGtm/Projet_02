﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;
namespace Data.Service
{
    public static class ServiceAgenceVoyage
    {
        /// <summary>
        /// méthode pour afficher des instances de la table AgenceVoyage
        /// </summary>
        public static IEnumerable<AgenceVoyage> GetAgences()
        {
            using (var contexte = new Contexte())
            {
                var agences = (from av in contexte.AgenceVoyages
                               select av).Include(x => x.Voyages).ToList();
                return agences;
            }
        }
        /// <summary>
        /// méthode pour afficher une instance de la table AgenceVoyage
        /// </summary>
        public static AgenceVoyage GetAgence(int IdAgence)
        {
            using (var contexte = new Contexte())
            {
                var agence = (from av in contexte.AgenceVoyages
                              where av.Id == IdAgence
                              select av).Include(x => x.Voyages).Single();
                return agence;
            }
        }
        /// <summary>
        /// méthode pour créer une nouvelle instance de AgenceVoyages sur la base.
		/// </summary>
		public static void CreerAgence(AgenceVoyage ag)
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
		public static void EffacerAgence(int idAgence)
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
		public static bool ChercherAgence(int idAgence)
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
        public static IEnumerable<Voyage> GetVoyagesParAgence(int idAgence)
        {
            using(var contexte = new Contexte())
            {
                var voyages = (from ag in contexte.AgenceVoyages
                               where ag.Id == idAgence
                               select ag.Voyages).Single();
                return voyages;
            }
        }
        /// <summary>
        /// méthode pour Modifier une agence.
        /// </summary>
        /// <param name="agenceVoyage ">modification de l'agence par OBJ</param>
        /// <returns></returns>
        public static void ModifierAgence(AgenceVoyage agenceVoyage)
        {
            using (var contexte = new Contexte())
            {
                contexte.AgenceVoyages.Attach(agenceVoyage);
                contexte.Entry(agenceVoyage).State = EntityState.Modified;
                contexte.SaveChanges();

            }
        }
    }
}
