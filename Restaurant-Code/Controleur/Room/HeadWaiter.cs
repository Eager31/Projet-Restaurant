using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    class HeadWaiter : Commun.Actor
    {
        public string name { get; set; }

        public HeadWaiter(string name)
        {
            this.name = name;
        }


    }
}
