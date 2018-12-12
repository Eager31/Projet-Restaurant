using Controleur.Commun;
using Controleur.Commun.Actions;
using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
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
            this.mapAct.Add("BringMealToCounter", new BringMealToCounter());
            this.mapAct.Add("CheckStocks", new CheckStocks());
            this.mapAct.Add("FillStocks", new FillStocks());
            this.mapAct.Add("RemoveFromStocks", new RemoveFromStocks());
        }
        


        //Intéragir avec les stocks
        public override void actionKitchenClerck(String choice, Storage stor, int number, Ingredients ingredient, Tuple<List<Dish>, int> tupleCommand, Counter counter)
        {
            switch (choice)
            {
                case "BringMealToCounter":
                    BringMealToCounter bringMealToCounter = (BringMealToCounter)this.mapAct["BringMealToCounter"];
                    this.lockAction = true;
                    bringMealToCounter.act(tupleCommand, counter);
                    this.lockAction = false;
                    break;
                case "ChopVegetables":
                    this.lockAction = true;
                    //this.checkTime(); //number en paramètre == duration ==> Va faire patienter le thread le temps qu'il découpe les légumes en fonction du temps de l'instruction
                    this.lockAction = false;
                    break;
                case "CheckStocks":
                    CheckStocks checkStock = (CheckStocks)this.mapAct["CheckStocks"];
                    checkStock.act(stor);
                    break;
                case "FillStocks":
                    FillStocks fillStocks = (FillStocks)this.mapAct["FillStocks"];
                    fillStocks.act(stor,number,ingredient);
                    break;
                case "RemoveFromStocks":
                    RemoveFromStocks removeFromStocks = (RemoveFromStocks)this.mapAct["RemoveFromStocks"];
                    removeFromStocks.act(stor, number, ingredient);
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
