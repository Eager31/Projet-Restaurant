using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class ClientPool
    {
        public int QueueLength = 0;

        public void CreateClientThread(string clientName, int clientAmount)
        {
            string ThreadName = "Thread " + clientName.ToString();
            Client client = new Client(clientName, clientAmount, 0);
            Console.WriteLine("Un nouveau client a été placé dans la file d'attente");
            ClientList.clientList.Add(client);

        }
        /*
        public void Produce(Client client, Commun.IAgir agir )
        {

            ThreadPool.QueueUserWorkItem(new WaitCallback(Agir), client);
            QueueLength++;
        }
        */

        /*
             //Sample 03: Create Thread Pool
            for (int client = 1; client < 51; client++)
                ThreadPool.QueueUserWorkItem(new WaitCallback(TaskCallBack), client);
            Thread.Sleep(10000);
         */
    }
}
