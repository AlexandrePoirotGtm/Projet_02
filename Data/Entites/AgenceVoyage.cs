using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data
{
    [Table("AgenceVoyages")]
    public class AgenceVoyage
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        /*[NotMapped]
        public List<Voyage> Voyages { get; set; }*/
        [NotMapped]
        public virtual ICollection<Voyage> Voyages { get; set; }
    }
}
