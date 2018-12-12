using Controleur.Cuisine;
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
    public interface IActor
    {
        void checkTime();
        void threadStart();
        void action(String choice);
        void actionMainChef(String choice, OrderTable orderTbl, Storage stor);
        void actionCook(String choice, Order order, KitchenClerck kc, Counter c, QueueKitchenTools queueKitchenTools);
        void actionKitchenClerck(String choice, Storage stor, int number, Ingredients ingredient, Tuple<List<Dish>, int> tupleCommand, Counter counter);
        void actionDishWasher(String choice, WashMachine washMachine, Object itemToWash);
    }
}
