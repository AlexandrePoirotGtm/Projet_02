using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data
{
    [Table("DossierReservations")]
    public class DossierReservation
    {

        public DossierReservation()
        {
        }
        public DossierReservation(string ncb, decimal prix, Voyage v, Client c)
        {
            NumeroCarteBancaire = ncb;
            PrixParPersonne = prix;
            Voyage = v;
            Client = c;
            EtatDossierReservation = Etat.EnAttente;
        }
        public DossierReservation(string ncb, decimal prix,Voyage v,Client c, List<Participant> p_s)
        {
            NumeroCarteBancaire = ncb;
            PrixParPersonne = prix;
            Voyage = v;
            Client  = c;
            Participants = p_s;
            EtatDossierReservation = Etat.EnAttente;
        }
        
        [Column("Id")]
        public int Id { get; set; }

        [Column("NumeroCarteBancaire")]
        public string NumeroCarteBancaire { get; set; }

        [Column("PrixParPersonne")]
        public decimal PrixParPersonne { get; set; }

        [Column("EtatDossierReservation")]
        public Etat EtatDossierReservation { get; set; }

        [NotMapped]
        public RaisonAnnulationDossier RaisonAnnulationDossier { get; set; }

        [NotMapped]
        public decimal PrixTotal { get; set; }

        /*     
        public Voyage Voyage { get; set; }
        public Client Client { get; set; }
        */

        [Column("IdVoyage")]
        public int IdVoyage { get; set; }
        [ForeignKey("IdVoyage")]
        public virtual Voyage Voyage { get; set; }

        [Column("IdClient")]
        public int IdClient { get; set; }
        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }

        [NotMapped]
        public List<Participant> Participants { get; set; }

        //[NotMapped]      -    
        public List<Assurance> Assurances { get; set; }


        void Annuler(RaisonAnnulationDossier raison)
        {
            RaisonAnnulationDossier = raison;
            EtatDossierReservation = Etat.Refusee;

        }

        void ValiderSolvabiliter()
        {
            EtatDossierReservation = Etat.EnCours;
        }

        void Accepter()
        {
            EtatDossierReservation = Etat.Acceptee;
        }
    }
}
