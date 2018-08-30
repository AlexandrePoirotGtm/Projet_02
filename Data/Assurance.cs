using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Assurance
    {
        int Id { get; set; }
        TypeAssurance TypeAssurance { get; set; }
        decimal Montant { get; set; }

        List<DossierReversation> dossiers { get; set; }
    }
}
