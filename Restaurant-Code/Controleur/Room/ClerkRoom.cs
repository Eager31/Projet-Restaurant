using Controleur.Commun;
using Modèle.Room;
using Modèle.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class ClerkRoom : Actor
    {
        public ClerkRoom(string name) : base(name)
        {
            this.name = name;

            // This is the clerk's roles
            this.mapAct.Add("BringBread", new BringBread()); // Can bring the bread
            this.mapAct.Add("BringJug", new BringJug()); // Can bring the Jug

            // But it can take also the waiter's role
            this.mapAct.Add("Serve", new Serve()); // Can serve the client
            this.mapAct.Add("CleanTable", new CleanTable()); // Can clean the table

        }
        public void Action(String choice, ElementTable table , EnumRoom.BreadType breadType = EnumRoom.BreadType.White, EnumRoom.JugType jugType = EnumRoom.JugType.Tap)
        {
            switch (choice)
            {
                case "BringBread": 
                    BringBread bringBread = (BringBread)this.mapAct["BringBread"];
                    bringBread.voidAct(table, breadType);
                    break;
                case "BringJug": 
                    BringJug bringJug = (BringJug)this.mapAct["BringJug"];
                    bringJug.voidAct(table, jugType);
                    break;
               /* case "Serve":
                    //this.mapAct["Serve"].voidAct();
                    break; */
                case "CleanTable": 
                    CleanTable cleanTable = (CleanTable)this.mapAct["CleanTable"];
                    cleanTable.voidAct(table);
                    break;
                default:
                    break;
            }
        }
    }
}
