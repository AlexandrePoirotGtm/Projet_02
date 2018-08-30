using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Personne
    {
        int Id { get; set; }
        string Civilité { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
        string Adresse { get; set; }
        string Telephone { get; set; }
        DateTime DateNaissance { get; set; }
        int Age { get; set; }
    }
}
