using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL;
namespace Data.Service
{
    public class ServiceClient
    {
        /// <summary>
		/// METODO QUE CRIA UM NOVO CLIENTE
		/// </summary>
		public void CreerClient(Client c)
        {
            using (var contexte = new Contexte())
            {

                contexte.Clients.Add(c);
                contexte.SaveChanges();
            }
        }
    }
}
