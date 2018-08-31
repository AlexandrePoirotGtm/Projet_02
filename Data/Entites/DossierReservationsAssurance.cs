using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Entites
{
    [Table("DossierReservationsAssurances")]
    public class DossierReservationsAssurance
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("IdDossierReservation")]
        public int IdDossierReservation { get; set; }
        [ForeignKey("IdDossierReservation")]
        public virtual DossierReservation DossierReservation { get; set; }

        [Column("IdAssurance")]
        public int IdAssurance { get; set; }
        [ForeignKey("IdAssurance")]
        public virtual Assurance Assurance { get; set; }

       
    }
}
