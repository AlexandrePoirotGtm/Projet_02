using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data.DAL
{
    public class Contexte: DbContext
    {
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<AgenceVoyage> AgenceVoyages { get; set; }
        public virtual DbSet<Voyage> Voyages { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Assurance> Assurances { get; set; }
        public virtual DbSet<DossierReservation> DossierReservations { get; set; }       
    }
}
