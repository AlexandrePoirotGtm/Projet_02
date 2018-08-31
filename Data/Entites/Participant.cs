using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Participants")]
    public class Participant : Personne
    {
        [Column("Reduction")]
        public float Reduction { get; set; }

        [Column("IdDossierReservation")]
        public int IdDossierReservation { get; set; }

        [ForeignKey("IdDossierReservation")]
        public virtual DossierReservation DossierReservation { get; set; }

        public override string ToString()
        {
            return $"({Id}) {Nom.ToUpper()},{Prenom.ToLower()} - Ad. {Adresse}";
        }
    }
}
