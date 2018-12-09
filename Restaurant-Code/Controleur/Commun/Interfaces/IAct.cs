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
        void voidAct(int number, Ingredients ingredient);
        void voidAct(Dish d);
        void voidAct(WashMachine washMachine, QueueKitchenTools queueKitchenTool);
        void voidAct(WashMachine washMachine, QueueRoomStuff queueRoomStuff);
        void voidAct(ElementTable elementTable);
        void eTableAct(Actor act);
        int intAct();
        Boolean boolAct();
        Boolean boolAct(OrderTable orderTbl, Storage stor);
        Boolean boolAct(Actor act);
        Dish dishAct(Order order);
        Dish dishAct();
        List<Ingredients> ingredientListAct(Storage stor);



    }
}
