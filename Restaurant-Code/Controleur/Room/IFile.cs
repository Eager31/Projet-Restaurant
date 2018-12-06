using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    interface IFile
    {
        void addClientList(Client client);
        void removeClientList(Client client);
    }
}
