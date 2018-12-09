using Controleur.Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Cuisine
{
    public class Cook : Actor
    {
        public Cook(string name) : base(name)
        {
            this.mapAct.Add("PrepareDish", new PrepareDish());
            this.mapAct.Add("PrepareMorningDish", new PrepareMorningDish());
        }

        public void Action(String choice, Order order)
        {
            switch (choice)
            {
                case "PrepareDish":
                    this.mapAct["PrepareDish"].dishAct(order);
                    break;
                case "PrepareMorningDish" :
                    this.mapAct["PrepareMorningDish"].dishAct();
                    break;
                case "CheckClock":
                    this.checkTime();
                    break;
                default:
                    //Do nothing ?
                    break;
            }
        }
        
    }
}
