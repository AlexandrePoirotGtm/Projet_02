using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Voyage
    {
        public int Id { get; set; }
        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public int PlaceDisponibles { get; set; }
        public decimal PrixParPersonne { get; set; }

        public Destination Destination { get; set; }
        public List<DossierReservation> Dossiers { get; set; }


        public void Reserver(int places)
        {
            
        }
    }
}
