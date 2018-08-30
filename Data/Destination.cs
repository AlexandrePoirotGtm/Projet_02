using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Destination
    {
        int Id { get; set; }
        string Continent { get; set; }
        string Pays { get; set; }
        string Region { get; set; }
        string Description { get; set; }

        List<Voyage> Voyages { get; set; }
    }
}
