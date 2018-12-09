using Controleur.Commun;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Cuisine
{
    public class KitchenClerck : Actor
    {
        public KitchenClerck(string name) : base(name)
        {
            this.mapAct.Add("CleanKitchen", new CleanKitchen());
            this.mapAct.Add("ChopVegetables", new ChopVegetables());
            this.mapAct.Add("CleanKitchenware", new CleanKitchenware());
            this.mapAct.Add("CleanTableware", new CleanTableware());
        }
        

        public void Action(String choice, WashMachine washMachine, Object itemToWash)
        {
            switch (choice)
            {
                case "CleanKitchen":
                    this.mapAct["CleanKitchen"].voidAct();
                    break;
                case "ChopVegetables":
                    this.mapAct["CleanKitchen"].voidAct(washMachine,(QueueKitchenTools) itemToWash);
                    break;
                case "CleanKitchenware":
                    this.mapAct["CleanKitchenware"].voidAct(washMachine, (QueueRoomStuff)itemToWash);
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
