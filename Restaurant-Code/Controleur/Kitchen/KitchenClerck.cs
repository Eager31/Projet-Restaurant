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
        public void Action(String choice, Storage stor, int number, Ingredients ingredient)
        {
            switch (choice)
            {
                case "ChopVegetables":
                    this.lockAction = true;
                    //this.checkTime(); //number en paramètre == duration ==> Va faire patienter le thread le temps qu'il découpe les légumes en fonction du temps de l'instruction
                    this.lockAction = false;
                    break;
                case "CheckStocks":
                    //this.mapAct["CheckStocks"].ingredientListAct(stor);
                    break;
                case "FillStocks":
                    //this.mapAct["FillStocks"].voidAct(number, ingredient);
                    break;
                case "RemoveFromStocks":
                    //this.mapAct["RemoveFromStocks"].voidAct(number, ingredient);
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
