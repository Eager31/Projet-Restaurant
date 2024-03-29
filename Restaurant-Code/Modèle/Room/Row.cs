﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Map;

namespace Modèle.Room
{
    public class Row : Modèle.Map.IElements
    {
        public int number { get; set; }
        public ElementTable table { get; set; }

        public Row(int number, ElementTable table)
        {
            this.number = number;
            this.table = table;
        }
    }
}
