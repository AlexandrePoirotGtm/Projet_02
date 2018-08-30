using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Assurance
    {
        public int Id { get; set; }
        public TypeAssurance TypeAssurance { get; set; }
        public decimal Montant { get; set; }

        public List<DossierReversation> dossiers { get; set; }
    }
}
