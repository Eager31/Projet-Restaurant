using Controleur.Cuisine;
using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.Interfaces
{
    public interface IVoidActWithOrderTableAndCook
    {
        void act(OrderTable orderTbl, Cook c);
    }
}
