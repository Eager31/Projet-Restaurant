using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Map;

namespace Modèle.Room
{
    class Row : Modèle.Map.IElements
    {
        public int number { get; set; }
        public ElementTable table;
    }
}
