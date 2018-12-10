using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Commun;

namespace Controleur.Room
{
    public class Client : Commun.Actor
    {
        public int number { get; set; } // The number of the client in the group
        public IEatBehavior behavior { get; set; } // The behavior for the strategy DP
        public int tableNumber { get; set; }

        public Client(string name, int number, int tableNumber) : base(name)
        {
            this.number = number;
            this.name = name;
            this.tableNumber = 0;


            // This the client behavior
            this.mapAct.Add("Order", new OrderAction()); // Can order to the Waiter
            this.mapAct.Add("Pay", new Pay()); // Can pay
        }

        public void Action(String choice)
        {
            switch (choice)
            {
                case "Order":
                    this.mapAct["Order"].voidAct();
                    break;
                case "Pay":
                    this.mapAct["Pay"].voidAct();
                    break;
                default:
                    break;
            }
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
