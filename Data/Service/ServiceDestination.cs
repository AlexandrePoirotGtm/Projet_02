using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;
namespace Data.Service
{
    public class ServiceDestination
    {
        /// <summary>
        /// méthode pour afficher des instances de la table destination
        /// </summary>
        public IEnumerable<Destination> GetDestinations()
        {
            using (var contexte = new Contexte())
            {
                var destinations = (from ds in contexte.Destinations
                               select ds).ToList();               
                return destinations;
            }
        }
        /// <summary>
        /// méthode pour afficher des instances de la table destination
        /// </summary>
        public Destination GetDestination(int IdDestination)
        {
            using (var contexte = new Contexte())
            {
                var destination = (from d in contexte.Destinations
                              where d.Id == IdDestination
                              select d).Single();               
                return destination;
            }
        }
        /// <summary>
        /// méthode pour créer une nouvelle instance de destination sur la base.
		/// </summary>
		public void CreerDestination(Destination d)
        {
            using (var contexte = new Contexte())
            {
                contexte.Destinations.Add(d);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance de destination sur la base pour son id.
		/// </summary>
		public void EffacerDestination(int idDestination)
        {
            using (var contexte = new Contexte())
            {
                var destination = (from d in contexte.Destinations
                                   where d.Id == idDestination
                                   select d).Single();
                contexte.Destinations.Remove(destination);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour voir si un destination est dans la base. Cherche pour son id.
		/// </summary>
		public bool ChercherDestination(int idDestination)
        {
            bool trouver = false;
            using (var contexte = new Contexte())
            {
                var destination = (from d in contexte.Destinations
                              where d.Id == idDestination
                              select d).Count();
                if (destination != 0) { trouver = true; }
            }
            return trouver;
        }
        /// <summary>
        /// méthode pour filtrer destination par Region.
        /// </summary>
        public IEnumerable<Destination> FiltrerDestinationRegion(string region)
        {            
            using (var contexte = new Contexte())
            {
                var destinations = (from d in contexte.Destinations
                                   where d.Region == region
                                    select d).ToList();
                return destinations;
            }
           
        }
        /// <summary>
        /// méthode pour filtrer destination par Pays.
        /// </summary>
        public IEnumerable<Destination> FiltrerDestinationPays(string pays)
        {
            using (var contexte = new Contexte())
            {
                var destinations = (from d in contexte.Destinations
                                    where d.Pays == pays
                                    select d).ToList();
                return destinations;
            }
        }
        /// <summary>
        /// méthode pour filtrer destination par Continent.
        /// </summary>
        public IEnumerable<Destination> FiltrerDestinationContinent(string continent)
        {
            using (var contexte = new Contexte())
            {
                var destinations = (from d in contexte.Destinations
                                    where d.Continent == continent
                                    select d).ToList();
                return destinations;
            }
        }
    }
}
