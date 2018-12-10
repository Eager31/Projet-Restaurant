using Controleur.Commun.Interfaces;
using Controleur.Commun.ObserverObservable;
using Controleur.Temps;
using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public abstract class Actor : IActor, IAct, IObserver<Counter>, IObserver<QueueKitchenTools>, IObserver<QueueRoomStuff>, IObserver<Clock>
    {

        public IDisposable cancellation { get; set; }
        public string name { get; set; }
        public List<string> itemInfo { get; set; }
        public Boolean lockAction { get; set; }
        public Dictionary<string,IAct> mapAct { get; set; }

    protected Actor(string name)
        {
            this.name = name;
            this.lockAction = false;
            this.mapAct = new Dictionary<string, IAct>();
        }

        /*Subscribe*/
        public virtual void SubscribeQueueRoomStuff(QueueRoomStuffHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void SubscribeQueueKitchenTools(QueueKitchenToolsHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }
    
        public virtual void SubscribeCounter(CounterHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void SubscribeClock(ClockHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        /*Unsub*/
        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            itemInfo.Clear();
        }

        public virtual void OnCompleted()
        {
            itemInfo.Clear();
        }

        /*Action after receving data*/
        public void OnNext(QueueKitchenTools info)
        {
            if (info.kitchenToolsQueue.Count > 0)
            {
                //traitement
                Console.WriteLine("List contains : {1} : elements - {0}", this.name, info.kitchenToolsQueue.Count);
            }
            else
            {
                //traitement
                Console.WriteLine("List is empty - {0}", this.name);
            }
        }

        public void OnNext(QueueRoomStuff info)
        {
            if (info.roomToolsQueue.Count > 0)
            {
                //traitement
                Console.WriteLine("List contains : {1} : elements - {0}", this.name, info.roomToolsQueue.Count);
            }
            else
            {
                //traitement
                Console.WriteLine("List is empty - {0}", this.name);
            }
        }
        public void OnNext(Counter info)
        {
            int cpt = 0;
            for (int i = 0; i < info.tabDish.Length; i++)
            {
                if (info.tabDish[i] != null)
                {
                    cpt++;
                }
            }
            if (cpt > 0)
            {
                //traitement
                Console.WriteLine("Counter contains : {1} : elements - {0}", this.name, cpt);
            }
            else
            {
                //traitement
                Console.WriteLine("Counter is empty - {0}", this.name);
            }
        }


        public void OnNext(Clock info)
        {
            //traitement
            Console.WriteLine("The clock is watched - {0}", this.name);
        }

        /* Thread */
        public void threadStart()
        {
            ThreadStart threadDelegate = new ThreadStart(this.action);
            Thread newThread = new Thread(threadDelegate);
            newThread.Start();
        }

        /*Functions*/

        public void action()
        {
            throw new NotImplementedException();
        }
        public void checkTime()
        {
            throw new NotImplementedException();
        }

        /*Others*/
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        /*Actions possibles*/
        public int intAct()
        {
            throw new NotImplementedException();
        }

        public void voidAct()
        {
            throw new NotImplementedException();
        }

        public bool boolAct()
        {
            throw new NotImplementedException();
        }

        public Dish dishAct(Order order)
        {
            throw new NotImplementedException();
        }

        public void voidAct(Dish d)
        {
            throw new NotImplementedException();
        }

        public List<Ingredients> ingredientListAct(Storage stor)
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

        public void eTableAct(Actor act)
        {
            throw new NotImplementedException();
        }

        public bool boolAct(Actor act)
        {
            throw new NotImplementedException();
        }

        public void voidAct(ElementTable elementTable)
        {
            throw new NotImplementedException();
        }

        public Dish dishAct()
        {
            throw new NotImplementedException();
        }

        public void voidAct(int number, Ingredients ingredient)
        {
            throw new NotImplementedException();
        }

        public bool boolAct(OrderTable orderTbl, Storage stor)
        {
            throw new NotImplementedException();
        }

        public void voidAct(OrderTable orderTbl)
        {
            throw new NotImplementedException();
        }

    }

}