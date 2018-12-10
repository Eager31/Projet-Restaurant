using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Commun;
using Modèle.Room;

namespace Controleur.Room
{
    public class HeadWaiter : Commun.Actor
    {
        public Square square { get; set; }

        public HeadWaiter(string name, Square square) : base(name)
        {
            this.name = name;
            this.square = square;

            this.mapAct.Add("BringMenu", new BringMenu()); // Can bring the card
            this.mapAct.Add("TakeOrder", new TakeOrder()); // Can take the order
            this.mapAct.Add("PlaceClient", new PlaceClient()); // Can place the client

        }

        public void Action(String choice)
        {
            switch (choice)
            {
                case "BringMenu":
                    this.mapAct["BringMenu"].voidAct();
                    break;
                case "TakeOrder":
                    this.mapAct["TakeOrder"].voidAct();
                    break;
                case "PlaceClient":
                    this.mapAct["PlaceClient"].voidAct();
                    break;
                default:
                    break;
            }
        }
    }
}
