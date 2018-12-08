using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class Client : Commun.Actor
    {

        public int number { get; set; }
        public string name { get; set; }

        public IEatBehavior behavior { get; set; }

        public Client(int number, string name)
        {
            this.number = number;
            this.name = name;
        }
        
        public void setBehavior(IEatBehavior behavior)
        {
            this.behavior = behavior;
        }
    }
}
