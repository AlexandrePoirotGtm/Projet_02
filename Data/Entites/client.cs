﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Client : Personne
    {
        public string Email { get; set; }
        public List<DossierReversation> Dossiers { get; set; }
    }
}
