using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Member
    {
        // Member ID
        public int ID { get; set; }

        // Member name (ex: John, Mike, Joe, ...)
        public string name { get; set; }

        // ID of role 
        public int roleID { get; set; }
    }
}
