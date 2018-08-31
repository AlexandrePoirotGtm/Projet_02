using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data
{
    [Table("Destinations")]
    public class Destination
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Continent")]
        public string Continent { get; set; }

        [Column("Pays")]
        public string Pays { get; set; }

        [Column("Region")]
        public string Region { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [NotMapped]
        public List<Voyage> Voyages { get; set; }
    }
}
