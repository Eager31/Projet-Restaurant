using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class Client : Commun.Actor 
    {

        public int number { get; set; } // The number of the client in the group
        public string name { get; set; } // The name of the client
        public IEatBehavior behavior { get; set; } // The behavior for the strategy DP

        public int tableNumber { get; set; }

        public Client(int number, string name)
        {
            this.number = number;
            this.name = name;
            this.tableNumber = 0;
        }
        
        public void setBehavior(IEatBehavior behavior) // Define the client's behavior
        {
            this.behavior = behavior;
        }

        public void setTableNumber(int number) // Attribute a table number
        {
            this.tableNumber = number;
        }
    }
}
