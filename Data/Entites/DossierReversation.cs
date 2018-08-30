using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DossierReversation
    {
        public int Id { get; set; }
        public int NuméroUnique { get; set; }
        public string NumeroCarteBancaire { get; set; }
        public decimal PrixParPersonne { get; set; }
        public decimal PrixTotal { get; set; }

        public Voyage Voyage { get; set; }
        public Client Client { get; set; }
        public Participant[] Participants { get; set; }
        //List<Participant> Participants { get; set; }
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
