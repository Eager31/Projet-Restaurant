using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Menu
    {
        public string name { get; set; }
        public List<Dish> dishList { get; set; }
        public Boolean isMenuOfTheDay { get; set; }

        public Menu(string name, List<Dish> dishList, Boolean isMenuOfTheDay)
        {
            this.name = name;
            this.dishList = dishList;
            this.isMenuOfTheDay = isMenuOfTheDay;
        }
    }
}
