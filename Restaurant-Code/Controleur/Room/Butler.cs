using Controleur.Commun;
using Controleur.Commun.ObserverObservable;
using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class Butler : Actor
    {
        public Butler(string name) : base(name) 
        {
            this.name = name;
            this.mapAct.Add("VerifyReservation", new VerifyReservation()); // Can Verify the reservation's list
            this.mapAct.Add("AssignTable", new AssignTable()); // Can assign a client to a table

        }
        public void Action(String choice)
        {
            switch (choice)
            {
                case "VerifyReservation":
                    //this.mapAct["VerifyReservation"].voidAct();
                    break;
                case "AssignTable":
                    //this.mapAct["AssignTable"].voidAct();
                    break;
                default:
                    break;
            }
        }
    }
}
