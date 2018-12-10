using Controleur.Commun;
using Controleur.Commun.ObserverObservable;
using Modèle.Cuisine;
using Modèle.Room;
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
        public void Action(String choice, Client client, ElementTable table = null)
        {
            switch (choice)
            {
                case "VerifyReservation":
                    VerifyReservation verifyReservation = (VerifyReservation)this.mapAct["VerifyReservation"];
                    verifyReservation.voidAct(client);
                    break;
                case "AssignTable": 
                    AssignTable assignTable = (AssignTable)this.mapAct["AssignTable"];
                    assignTable.voidAct(client, table);
                    break;
                default:
                    break;
            }
        }
    }
}
