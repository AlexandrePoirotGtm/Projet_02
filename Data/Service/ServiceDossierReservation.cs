using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
using System.Data.Entity;
namespace Data.Service
{
    public static class ServiceDossierReservation
    {
        /// <summary>
        /// méthode pour afficher des instances de la table DossierReservation
        /// </summary>
        public static IEnumerable<DossierReservation> GetDossierReservations()
        {
            using (var contexte = new Contexte())
            {
                var dossierReservations = (from dr in contexte.DossierReservations
                                           select dr).ToList();
                return dossierReservations;
            }
        }
        /// <summary>
        /// méthode pour afficher des instances de la table DossierReservation
        /// </summary>
        public static DossierReservation GetDossierReservation(int IdDossier)
        {
            using (var contexte = new Contexte())
            {
                var dossierReservation = (from dreservqtion in contexte.DossierReservations
                              where dreservqtion.Id == IdDossier
                              select dreservqtion).Single();
                return dossierReservation;
            }
        }
        /// <summary>
        /// méthode pour créer une nouvelle instance du DossierReservation sur la base.
		/// </summary>
		public static void CreerDossierReservation(DossierReservation dossier)
        {
            using (var contexte = new Contexte())
            {
                contexte.DossierReservations.Add(dossier);
                contexte.SaveChanges();
            }
        }
        /// <summary>
		/// méthode pour effacer une instance du DossierReservation sur la base pour son id.
		/// </summary>
        /// <param name="idDossier">identifiant du Dossier</param>
		public static void EffacerDossierReservation(int idDossier)
        {
            using (var contexte = new Contexte())
            {
                var dossierReservation = (from c in contexte.DossierReservations
                              where c.Id == idDossier
                              select c).Single();
                contexte.DossierReservations.Remove(dossierReservation);
                contexte.SaveChanges();
            }
        }

        /// <summary>
        /// méthode pour Modifier une instance du DossierReservation sur la base pour son OBJ.
        /// </summary>
        /// <param name="dossier">obj dossier</param>
        public static void ModifierDossierReservation(DossierReservation dossier)
        {
            using (var contexte = new Contexte())
            {
                contexte.DossierReservations.Attach(dossier);
                contexte.Entry(dossier).State = EntityState.Modified;
                contexte.SaveChanges();
            }
        }
        
    }
}
