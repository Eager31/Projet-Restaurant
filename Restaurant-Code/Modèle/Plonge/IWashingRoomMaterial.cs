﻿using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public interface IWashingRoomMaterial
    {
        int wash(QueueRoomTools roomToolList); //!!!!!!! ==> List<MaterielRoom>
    }
}
