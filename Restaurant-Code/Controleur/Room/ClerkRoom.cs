using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class ClerkRoom : Commun.Actor
    {
        public string name { get; set; }

        public ClerkRoom(string name)
        {
            this.name = name;
        }
    }
}
