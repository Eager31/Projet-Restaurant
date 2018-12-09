using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class Butler : Commun.Actor
    {
        public string name { get; set; }
        public Boolean lockAction { get; set; }

        public Butler(string name)
        {
            this.name = name;
            this.lockAction = false;
        }
    }

     
}
