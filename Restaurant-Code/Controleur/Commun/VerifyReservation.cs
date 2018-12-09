using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Room;
using Modèle.Room;

namespace Controleur.Commun
{
    public class VerifyReservation
    {
        public void act(Client client) // Verify if the client has a reservation
        {
            string name = client.name;
            foreach (BookingForm bookingForm in BookingList.bookingList) // Browse booking list
            {
                if(bookingForm.name == name) // If reservation founded :
                {
                    AssignTable.act(client, bookingForm.table); // Assign the table to the client
                }
            }
        }
    }
}
