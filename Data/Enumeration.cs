﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public enum Etat
    {
        EnAttente,
        EnCours,
        Refusee,
        Acceptee
    }

    public enum TypeAssurance
    {
        Annulation
    }

    public enum RaisonAnnulationDossier
    {
        Client,
        PlacesInsuffisantes
    }
}
