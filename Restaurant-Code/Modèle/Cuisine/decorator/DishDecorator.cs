using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public abstract class DishDecorator : Dish
    {
        public DishDecorator(Dish originalDish) : base(originalDish.name, originalDish.description, originalDish.listInstructions, originalDish.type, originalDish.state)
        {

        }
    }
}
