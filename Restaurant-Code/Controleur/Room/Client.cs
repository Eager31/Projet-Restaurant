using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class Client : Commun.Actor
    {

        private int number { get; set; }
        private string name { get; set; }

        private IEatBehavior behavior;

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
