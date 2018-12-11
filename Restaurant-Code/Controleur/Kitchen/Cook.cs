using Controleur.Commun;
using Modèle.Room;
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

        public void Action(String choice, Order order, KitchenClerck kc)
        {
            switch (choice)
            {
                case "PrepareDish":
                    PrepareDish prepare = (PrepareDish)this.mapAct["PrepareDish"];
                    prepare.act(order,kc,this);//Crée un dish à partir d'un order
                    break;
                case "PrepareMorningDish" :
                    PrepareMorningDish prepareMorningDish = (PrepareMorningDish) this.mapAct["PrepareMorningDish"];
                    prepareMorningDish.act();
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
