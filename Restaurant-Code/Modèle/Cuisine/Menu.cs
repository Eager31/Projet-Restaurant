using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Menu
    {
        private string name;
        private List<Dish> dishList;
        private Boolean isMenuOfTheDay;

        public Menu(string name, List<Dish> dishList, Boolean isMenuOfTheDay)
        {
            this.name = name;
            this.dishList = dishList;
            this.isMenuOfTheDay = isMenuOfTheDay;
        }
    }
}
