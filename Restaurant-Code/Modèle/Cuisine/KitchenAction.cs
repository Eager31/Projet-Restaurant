using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class KitchenAction
    {

        public string name { get; set; }
        public int duration { get; set; }

        public KitchenAction(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
        }

    }
}
