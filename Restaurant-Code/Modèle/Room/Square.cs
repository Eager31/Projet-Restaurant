using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    public class Square
    {
        public int number { get; set; }
        public Row row { get; set; }

        public Square(int number, Row row)
        {
            this.number = number;
            this.row = row;
        }
    }
}
