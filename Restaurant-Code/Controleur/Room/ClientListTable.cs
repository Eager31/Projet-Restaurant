using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room;

namespace Controleur.Room
{
    public static class ClientListTable
    {
        public static Dictionary<ElementTable, Client> clientAndTable = new Dictionary<ElementTable, Client>(); // Usefull to know how many clients are in the room
    }
}

