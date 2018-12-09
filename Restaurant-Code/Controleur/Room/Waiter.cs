using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Commun;
using Modèle.Room;

namespace Controleur.Room
{
    public class Waiter : Commun.Actor
    {
        public Square square { get; set; }
        public Row row { get; set; }

        public Waiter(string name, Square square, Row row) : base(name)
        {
            this.name = name;
            this.square = square;
            this.row = row;

            // This is the waiter's roles
            this.mapAct.Add("Serve", new Serve()); // Can serve the client
            this.mapAct.Add("CleanTable", new CleanTable()); // Can clean the table

            // But it can take also the clerk's role,
            this.mapAct.Add("BringBread", new BringBread()); // Can bring the bread
            this.mapAct.Add("Bringjug", new BringJug()); // Can bring the Jug
        }

        public void Action(String choice)
        {
            switch (choice)
            {
                case "Serve":
                    this.mapAct["Serve"].act();
                    break;
                case "CleanTable":
                    this.mapAct["CleanTable"].act();
                    break;
                case "BringBread":
                    this.mapAct["BringBread"].act();
                    break;
                case "Bringjug":
                    this.mapAct["Bringjug"].act();
                    break;
                default:
                    break;
            }
        }

    }
}
