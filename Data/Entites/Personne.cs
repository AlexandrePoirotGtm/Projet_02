using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data
{
    public abstract class Personne
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Civilite")]
        public string Civilite { get; set; }

        [Column("Nom")]
        public string Nom { get; set; }

        [Column("Prenom")]
        public string Prenom { get; set; }

        [Column("Adresse")]
        public string Adresse { get; set; }

        [Column("Telephone")]
        public string Telephone { get; set; }

        [Column("DateNaissance")]
        public DateTime DateNaissance { get; set; }

        [NotMapped]
        public int Age { get; set;}
    }
}
