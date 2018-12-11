using Controleur.Commun;
using Controleur.Commun.Actions;
using Controleur.Commun.ObserverObservable;
using Modèle.Cuisine;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Cuisine
{
    // Observer
    public class DishWasher : Actor
    {
        public DishWasher(string name) : base(name)
        {
            this.mapAct.Add("CleanKitchen", new CleanKitchen());
            this.mapAct.Add("ChopVegetables", new ChopVegetables());
            this.mapAct.Add("CleanKitchenware", new CleanKitchenware());
            this.mapAct.Add("CleanTableware", new CleanTableware());
        }

        //Intéragir avec la plonge
        public void Action(String choice, WashMachine washMachine, Object itemToWash)
        {
            switch (choice)
            {
                case "CleanKitchen":
                    CleanKitchen cleanKitchen = (CleanKitchen)this.mapAct["CleanKitchen"];
                    //cleanKitchen.act();
                    break;
                case "ChopVegetables":
                    //this.mapAct["CleanKitchen"].voidAct(washMachine,(QueueKitchenTools) itemToWash);
                    break;
                case "CleanKitchenware":
                    CleanKitchenware cleanKitchenware = (CleanKitchenware)this.mapAct["CleanKitchenware"];
                    cleanKitchenware.act((WashingKitchenTools)washMachine, (QueueKitchenTools)itemToWash);
                break;
                case "CleanTableware":
                    CleanTableware cleanTableware = (CleanTableware)this.mapAct["CleanTableware"];
                    cleanTableware.act((WashingRoomTools)washMachine, (QueueRoomStuff)itemToWash);
                    break;
                default:
                    //Do nothing ?
                    break;
            }
        }
    }
}

