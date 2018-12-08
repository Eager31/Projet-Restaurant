using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room;

namespace Controleur.Room
{
    public class HeadWaiter : Commun.Actor
    {
        public string name { get; set; }
        public Square square { get; set; }

        public HeadWaiter(string name, Square square)
        {
            this.name = name;
            this.square = square;
        }

    }
}
