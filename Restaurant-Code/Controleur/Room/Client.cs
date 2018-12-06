using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    class Client : Commun.Actor
    {

        public int number { get; set; }
        public string name { get; set; }

        public string type { get; set; }

        public Client(int number, string name, string type)
        {
            this.number = number;
            this.name = name;
            this.type = type;
        }
    }
}
