using Controleur.Commun.ObserverObservable;
using Controleur.Cuisine;
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
    public abstract class Actor : IActor, IObserver<Counter>, IObserver<QueueKitchenTools>, IObserver<QueueRoomStuff>, IObserver<Clock>
    {

        public IDisposable cancellation { get; set; }
        public string name { get; set; }
        public List<string> itemInfo { get; set; }
        public Boolean lockAction { get; set; }
        public Dictionary<string, Object> mapAct { get; set; }

    protected Actor(string name)
        {
            this.name = name;
            this.lockAction = false;
            this.mapAct = new Dictionary<string,Object>();
            this.threadStart();
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
        public virtual void OnNext(QueueKitchenTools info)
        {
            if (info.kitchenToolsQueue.Count > 0)
            {
                Console.WriteLine("List contains : {1} : elements - {0}", this.name, info.kitchenToolsQueue.Count);
            }
            else
            {
                //traitement
                Console.WriteLine("List is empty - {0}", this.name);
            }
        }

        public virtual void OnNext(QueueRoomStuff info)
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
        public virtual void OnNext(Counter info)
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

   
        public virtual void OnNext(Clock info)
        {
            //traitement
            Console.WriteLine("The clock is watched - {0}", this.name);
        }

        /* Thread */
        public virtual void threadStart()
        {
            ThreadStart threadDelegate = new ThreadStart(this.wait);
            Thread newThread = new Thread(threadDelegate);
            newThread.Start();
        }

        /*Actions*/

        public virtual void action(String choice)
        {
            throw new NotImplementedException();
        }

        public virtual void actionCook(string choice, Order order, KitchenClerck kc, Counter c, QueueKitchenTools queueKitchenTools)
        {
            throw new NotImplementedException();
        }

        public virtual void actionMainChef(string choice, OrderTable orderTbl, Storage stor)
        {
            throw new NotImplementedException();
        }

        public virtual void actionKitchenClerck(string choice, Storage stor, int number, Ingredients ingredient, Tuple<List<Dish>, int> tupleCommand, Counter counter)
        {
            throw new NotImplementedException();
        }

        public virtual void actionDishWasher(string choice, WashMachine washMachine, object itemToWash)
        {
            throw new NotImplementedException();
        }

        /* Others */
        
        public void checkTime()
        {
            throw new NotImplementedException();
        }
        
        public void wait()
        {
            //check the clock with undefinied time before aknowledging and order
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }


    }

}