using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.Interfaces
{
    public interface IAct
    {
        void voidAct();
        Boolean boolAct();
        int intAct();
        Dish dishAct(Order order);
        Dish dishAct();
        void voidAct(Dish d);
        List<Ingredients> ingredientListAct(Storage stor);
        void voidAct(WashMachine washMachine, QueueKitchenTools queueKitchenTool);
        void voidAct(WashMachine washMachine, QueueRoomStuff queueRoomStuff);
        void eTableAct(Actor act);
        Boolean boolAct(Actor act);
        void voidAct(ElementTable elementTable);

    }
}
