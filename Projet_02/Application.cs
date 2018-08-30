using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;

namespace Projet_02
{
    public class Application : ApplicationBase
    {
        public Application()
            : base("BO Voyage")
        {

        }

        public Module1 Module1 { get; private set; }

        protected override void InitialiserModules()
        {
            this.Module1 = this.AjouterModule(new Module1(this, "Module 1"));
        }
    }
}
