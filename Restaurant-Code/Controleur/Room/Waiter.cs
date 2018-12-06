using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    class Waiter : Commun.Actor
    {
        public string name { get; set; }

        public Waiter(string name)
        {
            this.name = name;
        }


    }
}
