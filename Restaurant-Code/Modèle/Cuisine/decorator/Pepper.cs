using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Pepper : DishDecorator
    {
        public Pepper(Dish originalDish) : base(originalDish)
        {
            this.description += ", with pepper";
        }


    }
}
