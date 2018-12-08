using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public interface IQueue
    {
        void addClientInList(Client client);
        void removeClientInList(Client client);
    }
}
