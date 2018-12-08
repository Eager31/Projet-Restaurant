using Controleur.Commun.ObserverObservable;
using Modèle.Cuisine;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public abstract class Actor : IActor, IObserver<Counter>, IObserver<QueueKitchenTools>, IObserver<QueueRoomTools>
    {

        private IDisposable cancellation;
        private string name;
        private List<string> itemInfo = new List<string>();

        public IDisposable Cancellation { get => cancellation; set => cancellation = value; }
        public string Name { get => name; set => name = value; }
        public List<string> ItemInfo { get => itemInfo; set => itemInfo = value; }

        protected Actor(string name)
        {
            this.Name = name;
        }

        /*Subscribe*/
        public virtual void SubscribeQueueRoomStuff(QueueRoomStuffHandler provider)
        {
            Cancellation = provider.Subscribe(this);
        }

        public virtual void SubscribeQueueKitchenTools(QueueKitchenToolsHandler provider)
        {
            Cancellation = provider.Subscribe(this);
        }
    
        public virtual void SubscribeCounter(CounterHandler provider)
        {
            Cancellation = provider.Subscribe(this);
        }

        /*Unsub*/
        public virtual void Unsubscribe()
        {
            Cancellation.Dispose();
            ItemInfo.Clear();
        }

        public virtual void OnCompleted()
        {
            ItemInfo.Clear();
        }

        /*Action after receving data*/
        public void OnNext(QueueKitchenTools info)
        {
            if (info.KitchenToolsQueue.Count > 0)
            {
                //traitement
                Console.WriteLine("List contains : {1} : elements - {0}", this.Name, info.KitchenToolsQueue.Count);
            }
            else
            {
                //traitement
                Console.WriteLine("List is empty - {0}", this.Name);
            }
        }

        public void OnNext(QueueRoomTools info)
        {
            if (info.RoomToolsQueue.Count > 0)
            {
                //traitement
                Console.WriteLine("List contains : {1} : elements - {0}", this.Name, info.RoomToolsQueue.Count);
            }
            else
            {
                //traitement
                Console.WriteLine("List is empty - {0}", this.Name);
            }
        }
        public void OnNext(Counter info)
        {
            int cpt = 0;
            for (int i = 0; i < info.TabDish.Length; i++)
            {
                if (info.TabDish[i] != null)
                {
                    cpt++;
                }
            }
            if (cpt > 0)
            {
                //traitement
                Console.WriteLine("Counter contains : {1} : elements - {0}", this.Name, cpt);
            }
            else
            {
                //traitement
                Console.WriteLine("Counter is empty - {0}", this.Name);
            }
        }

        /* Thread */
        public void threadStart()
        {
            ThreadStart threadDelegate = new ThreadStart(this.act);
            Thread newThread = new Thread(threadDelegate);
            newThread.Start();
        }

        /*Functions*/
        public void act()
        {
            throw new NotImplementedException();
        }

        public int intAgir()
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


    }

}