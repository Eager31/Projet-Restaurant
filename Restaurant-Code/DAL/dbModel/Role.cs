using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Role
    {
        // Role ID
        public int ID { get; set; }

        // Role name (ex: waiter, butler, cook, ...)
        public string name { get; set; }

        // Amount of a certain role in the restaurant
        public int nbStaffMember { get; set; }
    }
}
