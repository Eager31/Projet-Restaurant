using Controleur.Commun.ObserverObservable;
using Controleur.Plonge;
using Controleur.Temps;
using Modèle.Cuisine;
using Modèle.Room;
using Modèle.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public abstract class WashMachine : IObserver<Clock>
    {
        public string name { get; set; }
        public int washTime { get; set; }
        public int maxToolNumber { get; set; }
        public Boolean isRunning { get; set; }
        public List<Object> toolsToWash { get; set; }
        public List<string> itemInfo { get; set; }
        public IDisposable cancellation { get; set; }
        public Enum typeMachine { get; set; }

        public WashMachine(int washTime, int maxToolNumber, string name)
        {
            this.washTime = washTime;
            this.maxToolNumber = maxToolNumber;
            this.name = name;
            this.toolsToWash = new List<Object>();

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

        public void OnNext(Clock info)
        {
            //traitement
            Console.WriteLine("The clock is watched - {0}", this.name);
        }


        /* Thread */
        public void threadStart()
        {
            
            ThreadStart threadDelegate = new ThreadStart(this.wash);
            Thread newThread = new Thread(threadDelegate);
            newThread.Start();
        }

        public void wash()
        {
            //Wash
        }

        public void addToWash(Object objToWash)
        {
            //addToWash
        }

        public void endWash()
        {
            //endWash
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
    }
}
