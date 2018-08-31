using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;

namespace Data.Service
{
    public class ServiceClient
    {
        /// <summary>
            /// méthode pour afficher des instances de la table client
            /// </summary>
        public IEnumerable<Client> GetClients()
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
        public Client GetClient(int IdClient)
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
		public void CreerClient(Client c)
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
		public void EffacerClient(int idClient)
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

        /*
        /// <summary>
		/// méthode pour effacer une instance du client sur la base pour son id.
		/// </summary>
        /// <param name="client">obj client</param>
		public void EffacerClient(Client client)
        {
            using (var contexte = new Contexte())
            {
                contexte.
                contexte.Client.Remove(client);
                contexte.SaveChanges();
            }
        }
        */

        /// <summary>
		/// méthode pour voir si un client est dans la base. Cherche pour son id.
		/// </summary>
		public bool ChercherClient(int idClient)
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
        /// méthode pour voir si un client est dans la base. Cherche pour son Nom.
        /// </summary>
        public bool ChercherClientParNom(string nomClient)
        {
            bool trouver = false;
            using (var contexte = new Contexte())
            {
                var client = (from c in contexte.Client
                              where c.Nom == nomClient
                              select c).Count();
                if (client != 0) { trouver = true; }
            }
            return trouver;
        }
    }
}
