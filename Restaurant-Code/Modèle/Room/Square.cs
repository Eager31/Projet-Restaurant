using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    public class Square
    {
        private int number { get; set; }
        private Row row;

        public Square(int number, Row row)
        {
            this.number = number;
            this.row = row;
        }
    }
}
