using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Client : Personne
    {
        string Email { get; set; }
        List<DossierReversation> dossiers { get; set; }
    }
}
