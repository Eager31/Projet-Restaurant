using Controleur.Commun.Interfaces;
using Controleur.Room;
using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public class VerifyReservation //: IAct
    {
        public void voidAct(Client client) // Verify if the client has a reservation
        {
            string name = client.name;
            foreach (BookingForm bookingForm in BookingList.bookingList) // Browse booking list
            {
                if(bookingForm.name == name) // If reservation founded :
                {
                    AssignTable assignTable = new AssignTable();
                    assignTable.voidAct(client, bookingForm.table); // Assign the table to the client
                }
            }
        }
    }
}
