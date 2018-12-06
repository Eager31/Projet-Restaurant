using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    class BookingForm
    {
        string name;
        ElementTable table;
        int hour;

        public BookingForm(string name, ElementTable table, int hour)
        {
            this.name = name;
            this.table = table;
            this.hour = hour;
        }
    }
}
