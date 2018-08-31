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
        public int Id { get; set; }        
        public string NumeroCarteBancaire { get; set; }
        public decimal PrixParPersonne { get; set; }

        [NotMapped]
        public decimal PrixTotal { get; set; }
             
        public Voyage Voyage { get; set; }
        public Client Client { get; set; }

        [NotMapped]
        public Participant[] Participants { get; set; }
       

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
