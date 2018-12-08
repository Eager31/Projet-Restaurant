using Controleur.Commun.ObserverObservable;
using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    public class Butler : Commun.Actor, IObserver<Counter>
    {
        private string name { get; set; }
        private ClientList clientList { get; set; }
        private IDisposable cancellation;
        private List<string> counterInfo = new List<string>();
    
        public Butler(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned a name.");
            this.name = name;
        }

        //S'abonner à la file de la room stuf
        public virtual void SubscribeCounter(CounterHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }
        
        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            counterInfo.Clear();
        }

        public virtual void OnCompleted()
        {
            counterInfo.Clear();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public virtual void OnError(Exception e)
        {
            // No implementation.
        }

        public void OnNext(Counter info)
        {
            int cpt = 0;
            for (int i = 0; i < info.TabDish.Length; i++){
                if (info.TabDish[i] != null)
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
    }

}
