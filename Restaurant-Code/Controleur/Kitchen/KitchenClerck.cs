using Controleur.Commun;
using Controleur.Commun.Actions;
using Modèle.Cuisine;
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
            this.mapAct.Add("CheckStocks", new CheckStocks());
            this.mapAct.Add("FillStocks", new FillStocks());
            this.mapAct.Add("RemoveFromStocks", new RemoveFromStocks());
        }
        

        //Intéragir avec la plonge
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
                default:
                    //Do nothing ?
                    break;
            }
        }
        //Intéragir avec les stocks
        public void Action(String choice, Storage stor, int number, Ingredients ingredient)
        {
            switch (choice)
            {
                case "CheckStocks":
                    this.mapAct["CheckStocks"].ingredientListAct(stor);
                    break;
                case "FillStocks":
                    this.mapAct["FillStocks"].voidAct(number, ingredient);
                    break;
                case "RemoveFromStocks":
                    this.mapAct["RemoveFromStocks"].voidAct(number, ingredient);
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
