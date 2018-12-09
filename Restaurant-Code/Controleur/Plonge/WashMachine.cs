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
        private string name;
        private int washTime;
        private int maxToolNumber;
        private Boolean isRunning; //lock
        private List<Object> toolsToWash;
        private List<string> itemInfo;
        private IDisposable cancellation;
        private Enum typeMachine;

        public WashMachine(int washTime, int maxToolNumber, string name)
        {
            this.WashTime = washTime;
            this.MaxToolNumber = maxToolNumber;
            this.Name = name;
            this.toolsToWash = new List<Object>();

        }

        public int WashTime { get => washTime; set => washTime = value; }
        public int MaxToolNumber { get => maxToolNumber; set => maxToolNumber = value; }
        public List<string> ItemInfo { get => itemInfo; set => itemInfo = value; }
        public IDisposable Cancellation { get => cancellation; set => cancellation = value; }
        public string Name { get => name; set => name = value; }
        public bool IsRunning { get => isRunning; set => isRunning = value; }
        public List<object> ToolsToWash { get => toolsToWash; set => toolsToWash = value; }
        public Enum TypeMachine { get => typeMachine; set => typeMachine = value; }

        public virtual void SubscribeClock(ClockHandler provider)
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

        public void OnNext(Clock info)
        {
            //traitement
            Console.WriteLine("The clock is watched - {0}", this.Name);
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
