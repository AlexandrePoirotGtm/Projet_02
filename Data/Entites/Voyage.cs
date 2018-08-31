﻿using System;
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
        public int Id { get; set; }
        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public int PlaceDisponibles { get; set; }
        public decimal PrixParPersonne { get; set; }

        //public Destination Destination { get; set; }
        public int IdDestination { get; set; }

        [ForeignKey("IdDestination")]
        public virtual Destination Destination { get; set; }

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
