using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    class ClientList : IFile
    {
        public static List<Client> clientList;

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
