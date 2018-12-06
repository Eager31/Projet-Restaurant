using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    class Butler : Commun.Actor
    {
        public string name { get; set; }


        public Butler(string name)
        {
            this.name = name;
            ClientList.clientList = new List<Client>();
        }
    }

     
}
