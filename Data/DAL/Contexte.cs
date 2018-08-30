using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data.DAL
{
    public class Contexte: DbContext
    {
        public virtual DbSet<Client> Clients { get; set; }
    }
}
