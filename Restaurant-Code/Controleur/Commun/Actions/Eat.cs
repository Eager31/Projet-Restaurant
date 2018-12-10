using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Room;

namespace Controleur.Commun.Actions
{
    class Eat
    {
        // Because we don't have time to finish the clock i can't manage the speed increase
        public void voidAct(Client client) // Allow the client to eat and so spend a specific time
        {
            if(client.behavior == "relax")
            {
                System.Threading.Thread.Sleep(30000); // Wait 30 seconds 

            }
            else if (client.behavior == "StressedOut")
            {
                System.Threading.Thread.Sleep(200000);// Wait 200 seconds 

            }
        }
    }
}
