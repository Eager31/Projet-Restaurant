﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room.Element;

namespace Modèle.Room
{
    public class Drink
    {
        public string name { get; set; }
        public Enum type { get; set; }

        public Drink(string name, EnumRoom.DrinkType type)
        {
            this.name = name;
            this.type = type;
        }

    }
}
