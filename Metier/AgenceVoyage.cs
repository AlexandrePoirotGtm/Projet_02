using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class AgenceVoyage
    {
        int Id { get; set; }
        string Nom { get; set; }

        List<Voyage> Voyages { get; set; }
    }
}
