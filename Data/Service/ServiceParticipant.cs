using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;
namespace Data.Service
{
    public static class ServiceParticipant
    {
        /// <summary>
        /// méthode pour afficher des instances de la table pqrticipant
        /// </summary>
        public static IEnumerable<Participant> GetParticipants()
        {
            using (var contexte = new Contexte())
            {
                var participants = (from p in contexte.Participants
                               select p).ToList();              
                return participants;
            }
        }
        /// <summary>
        /// méthode pour afficher des instances de la table pqrticipant
        /// </summary>
        public static Participant GetParticipant(int IdParticipant)
        {
            using (var contexte = new Contexte())
            {
                var participant = (from p in contexte.Participants
                                   where p.Id == IdParticipant
                                   select p).Single();               
                return participant;
            }
        }
        /// <summary>
        /// méthode pour créer une nouvelle instance du participant sur la base.
		/// </summary>
		public static void CreerParticipant(Participant p,int IdDossier)
        {
            using (var contexte = new Contexte())
            {
                p.IdDossierReservation = IdDossier;
                contexte.Participants.Add(p);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance du participant sur la base pour son id.
		/// </summary>
		public static void EffacerParticipant(int idParticipant)
        {
            using (var contexte = new Contexte())
            {
                var participant = (from p in contexte.Participants
                              where p.Id == idParticipant
                                   select p).Single();
                contexte.Participants.Remove(participant);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour voir si un Participant est dans la base. Cherche pour son id.
		/// </summary>
		public static bool ChercherParticipant(int idParticipant)
        {
            bool trouver = false;
            using (var contexte = new Contexte())
            {
                var participant = (from p in contexte.Participants
                              where p.Id == idParticipant
                              select p).Count();
                if (participant != 0) { trouver = true; }
            }
            return trouver;
        }
        
    }
}
