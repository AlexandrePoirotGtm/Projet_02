using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data
{
    [Table("Assurances")]
    public class Assurance
    {

        public int Id { get; set; }
        public TypeAssurance TypeAssurance { get; set; }
        public decimal Montant { get; set; }

        //[NotMapped]
        //public List<DossierReservation> dossiers { get; set; }
    }
}
