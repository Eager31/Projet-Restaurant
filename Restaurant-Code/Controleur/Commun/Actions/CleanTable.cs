using Controleur.Commun.Interfaces;
using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public class CleanTable : IAct
    {
        public bool boolAct()
        {
            throw new NotImplementedException();
        }

        public bool boolAct(Actor act)
        {
            throw new NotImplementedException();
        }

        public Dish dishAct(Order order)
        {
            throw new NotImplementedException();
        }

        public Dish dishAct()
        {
            throw new NotImplementedException();
        }

        public void eTableAct(Actor act)
        {
            throw new NotImplementedException();
        }

        public List<Ingredients> ingredientListAct(Storage stor)
        {
            throw new NotImplementedException();
        }

        public int intAct()
        {
            throw new NotImplementedException();
        }

        public void voidAct()
        {
            throw new NotImplementedException();
        }

        public void voidAct(Dish d)
        {
            throw new NotImplementedException();
        }

        public void voidAct(WashMachine washMachine, QueueKitchenTools queueKitchenTool)
        {
            throw new NotImplementedException();
        }

        public void voidAct(WashMachine washMachine, QueueRoomStuff queueRoomStuff)
        {
            throw new NotImplementedException();
        }

        public void voidAct(ElementTable elementTable)
        {
            throw new NotImplementedException();
        }

        public void voidAct(int number, Ingredients ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
