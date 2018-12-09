using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room;

namespace Controleur.Room
{
    public class Waiter : Commun.Actor
    {
        public string name { get; set; }
        public Square square { get; set; }
        public Row row { get; set; }
        public Boolean lockAction { get; set; }
        public Waiter(string name, Square square, Row row)
        {
            this.name = name;
            this.square = square;
            this.row = row;
            this.lockAction = false;
        }
    }
}
