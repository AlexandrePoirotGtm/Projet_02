using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data
{
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
        }
        public DossierReservation(string ncb, decimal prix,Voyage v,Client c, List<Participant> p_s)
        {
            NumeroCarteBancaire = ncb;
            PrixParPersonne = prix;
            Voyage = v;
            Client  = c;
            Participants = p_s;
        }
        

        public int Id { get; set; }        
        public string NumeroCarteBancaire { get; set; }
        public decimal PrixParPersonne { get; set; }
        public Etat EtatDossierReservation { get; set; }
        [NotMapped]
        public decimal PrixTotal { get; set; }
             
        public Voyage Voyage { get; set; }
        public Client Client { get; set; }

        [NotMapped]
        public List<Participant> Participants { get; set; }
       

        public List<Assurance> Assurances { get; set; }


        void Annuler(RaisonAnnulationDossier raison)
        {

        }

        void ValiderSolvabiliter()
        {

        }

        void Accepter()
        {

        }
    }
}
