using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class Butler : Commun.Actor
    {
        private string name { get; set; }
        private ClientList clientList { get; set; }

        public Butler(string name)
        {
            this.name = name;
        }
    }

     
}
