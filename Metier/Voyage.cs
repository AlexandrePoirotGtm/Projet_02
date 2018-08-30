using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Voyage
    {
        int Id { get; set; }
        DateTime DateAller { get; set; }
        DateTime DateRetour { get; set; }
        int PlaceDisponibles { get; set; }
        decimal PrixParPersonne { get; set; }

        Destination Destination { get; set; }
        List<DossierReversation> Dossiers { get; set; }


        public void Reserver(int places)
        {
            
        }
    }
}
