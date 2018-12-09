using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Salt : DishDecorator
    {
        public Salt(Dish originalDish) : base(originalDish)
        {
            this.description += ", with salt";
        }
    }
}
