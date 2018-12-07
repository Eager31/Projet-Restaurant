using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class KitchenAction
    {

        private string name;
        private int duration;
        public KitchenAction(string name, int duration)
        {
            this.Name = name;
            this.Duration = duration;
        }

        public string Name { get => name; set => name = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}
