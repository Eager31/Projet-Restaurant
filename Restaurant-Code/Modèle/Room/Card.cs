using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Kitchen.Menu;

namespace Modèle.Room
{
    public class Card
    {
        List<Menu> menus = new List<Menu>();
        List<Drink> drinks = new List<Drink>();

        public Card(List<Menu> menus, List<Drink> drinks)
        {
            this.menus = menus;
            this.drinks = drinks;
        }
    }
}
