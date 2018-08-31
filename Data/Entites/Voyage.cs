using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Voyages")]
    public class Voyage
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("DateAller")]
        public DateTime DateAller { get; set; }

        [Column("DateRetour")]
        public DateTime DateRetour { get; set; }

        [Column("PlaceDisponibles")]
        public int PlaceDisponibles { get; set; }

        [Column("PrixParPersonne")]
        public decimal PrixParPersonne { get; set; }

        //public Destination Destination { get; set; }
        [Column("IdDestination")]
        public int IdDestination { get; set; }

        [ForeignKey("IdDestination")]
        public virtual Destination Destination { get; set; }

        [Column("IdAgenceVoyage")]
        public int IdAgenceVoyage { get; set; }

        [ForeignKey("IdAgenceVoyage")]
        public virtual AgenceVoyage AgenceVoyage { get; set; }

        [NotMapped]
        public List<DossierReservation> Dossiers { get; set; }


        public void Reserver(int places)
        {
            
        }
    }
}
