using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class ClientList : IQueue
    {
        private static List<Client> clientList { get; set; }

        public void addClientList(Client client)
        {
            clientList.Add(client);
        }

        public void removeClientList(Client client)
        {
            clientList.Remove(client);
        }
    }
}
