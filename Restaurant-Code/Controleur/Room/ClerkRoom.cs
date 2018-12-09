using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Commun;

namespace Controleur.Room
{
    public class ClerkRoom : Commun.Actor
    {
        public ClerkRoom(string name) : base(name)
        {
            this.name = name;

            // This is the clerk's roles
            this.mapAct.Add("BringBread", new BringBread()); // Can bring the bread
            this.mapAct.Add("Bringjug", new BringJug()); // Can bring the Jug

            // But it can take also the waiter's role
            this.mapAct.Add("Serve", new Serve()); // Can serve the client
            this.mapAct.Add("CleanTable", new CleanTable()); // Can clean the table

        }
        public void Action(String choice)
        {
            switch (choice)
            {
                case "BringBread":
                    this.mapAct["BringBread"].act();
                    break;
                case "Bringjug":
                    this.mapAct["Bringjug"].act();
                    break;
                case "Serve":
                    this.mapAct["Serve"].act();
                    break;
                case "CleanTable":
                    this.mapAct["CleanTable"].act();
                    break;
                default:
                    break;
            }
        }
    }
}
