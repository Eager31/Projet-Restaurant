using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    public class BookingForm
    {
        public string name { get; set; }
        public ElementTable table { get; set; }
        public DateTime hour { get; set; }

        public BookingForm(string name, ElementTable table, DateTime hour)
        {
            this.name = name;
            this.table = table;
            this.hour = hour;
        }
    }
}
