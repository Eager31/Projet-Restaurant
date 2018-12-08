using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    public class Room
    {

        public int number { get; set; }
        public Square square { get; set; }

        public Room(int number, Square square)
        {
            this.number = number;
            this.square = square;
        }
    }
}
