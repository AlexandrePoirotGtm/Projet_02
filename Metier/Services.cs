using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Service;
using Data;
namespace Metier
{
    public static class Services
    {
        public static void CreerClient(string nom, string prenom, string civilite, string adresse, string telephone, DateTime dateNaissance, string email)
        {
            Client cli = new Client
            {
                Nom = nom,
                Prenom = prenom,
                Civilite = civilite,
                Adresse = adresse,
                Telephone = telephone,
                DateNaissance = dateNaissance,
                Email = email
            };

            ServiceClient serviceClient = new ServiceClient();
            serviceClient.CreerClient(cli);
        }

        public static void CreerAssurance(decimal montant,TypeAssurance typeAssurance)
        {
            Assurance assurance = new Assurance
            {
                Montant = montant,
                TypeAssurance = typeAssurance
            };

            ServiceAssurance serviceAssurance = new ServiceAssurance();
            serviceAssurance.CreerAssurance(assurance);
        }
    }
}
