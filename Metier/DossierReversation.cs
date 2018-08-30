using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
namespace Metier
{
    class DossierReversation
    {
        int Id { get; set; }
        int NuméroUnique { get; set; }
        string NumeroCarteBancaire { get; set; }
        decimal PrixParPersonne { get; set; }
        decimal PrixTotal { get; set; }

        Voyage Voyage { get; set; }
        Client Client { get; set; }
        Participant[] Participants { get; set; }
        //List<Participant> Participants { get; set; }
        List<Assurance> Assurances { get; set; }


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
