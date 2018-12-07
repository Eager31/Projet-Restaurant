using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    public class BookingForm
    {
        private string name { get; set; }
        private ElementTable table { get; set; }
        private DateTime hour { get; set; }

        public BookingForm(string name, ElementTable table, DateTime hour)
        {
            this.name = name;
            this.table = table;
            this.hour = hour;
        }
    }
}
