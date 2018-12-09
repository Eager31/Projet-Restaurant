using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Cream : DishDecorator
    {
        public Cream(Dish originalDish) : base(originalDish)
        {
            this.description += ", with cream";
        }
    }
}
