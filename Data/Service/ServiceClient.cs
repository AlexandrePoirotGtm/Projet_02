using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;

namespace Data.Service
{
    public static class ServiceClient
    {
        /// <summary>
            /// méthode pour afficher des instances de la table client
            /// </summary>
        public static IEnumerable<Client> GetClients()
        {
            using (var contexte = new Contexte())
            {
                var clients = (from c in contexte.Client
                               select c).ToList();                
                return clients;
            }
        }
        /// <summary>
        /// méthode pour afficher des instances de la table client
        /// </summary>
        public static Client GetClient(int IdClient)
        {
            using (var contexte = new Contexte())
            {
                var client = (from c in contexte.Client
                              where c.Id == IdClient
                               select c).Single();
                return client;
            }
        }
        /// <summary>
        /// méthode pour créer une nouvelle instance du client sur la base.
		/// </summary>
		public static void CreerClient(Client c)
        {
            using (var contexte = new Contexte())
            {                
                contexte.Client.Add(c);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance du client sur la base pour son id.
		/// </summary>
        /// <param name="idClient">identifiant du client</param>
		public static void EffacerClient(int idClient)
        {
            using (var contexte = new Contexte())
            {
                var client = (from c in contexte.Client
                              where c.Id == idClient
                              select c).Single();
                contexte.Client.Remove(client);
                contexte.SaveChanges();
            }
        }
        
        /// <summary>
		/// méthode pour effacer une instance du client sur la base pour son OBJ.
		/// </summary>
        /// <param name="client">obj client</param>
		public static void EffacerClient(Client client)
        {
            using (var contexte = new Contexte())
            {
                contexte.Entry(client).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }

        /// <summary>
        /// méthode pour Modifier une instance du client sur la base pour son OBJ.
        /// </summary>
        /// <param name="client">obj client</param>
        public static void ModifierClient(Client client)
        {
            using (var contexte = new Contexte())
            {
                contexte.Client.Attach(client);
                contexte.Entry(client).State = EntityState.Modified;
                contexte.SaveChanges();
            }
        }

        /// <summary>
		/// méthode pour voir si un client est dans la base. Cherche pour son id.
		/// </summary>
		public static bool ChercherClient(int idClient)
        {
            bool trouver = false;
            using (var contexte = new Contexte())
            {
                var client = (from c in contexte.Client
                              where c.Id == idClient
                              select c).Count();
                if (client != 0) { trouver = true; }
            }
            return trouver;
        }
        /// <summary>
        /// méthode pour afficher des client. Cherche pour son Nom.
        /// </summary>
        public static IEnumerable<Client> FiltrerClientParNom(string nomClient)
        {
            using (var contexte = new Contexte())
            {
                var clients = (from c in contexte.Client
                               where c.Nom == nomClient
                               select c).ToList();
                return clients;
            }
        }
        /// <summary>
        /// méthode pour afficher des client. Cherche pour son Prenom.
        /// </summary>
        public static IEnumerable<Client> FiltrerClientParPrenom(string prenomClient)
        {
            using (var contexte = new Contexte())
            {
                var clients = (from c in contexte.Client
                               where c.Prenom == prenomClient
                               select c).ToList();
                return clients;
            }
        }

    }
}
