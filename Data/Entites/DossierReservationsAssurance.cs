using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Entites
{
    public class DossierReservationsAssurance
    {
        public int Id { get; set; }

        public int IdDossierReservation { get; set; }
        [ForeignKey("IdDossierReservation")]
        public virtual DossierReservation DossierReservation { get; set; }

        public int IdAssurance { get; set; }
        [ForeignKey("IdAssurance")]
        public virtual Assurance Assurance { get; set; }

       
    }
}
