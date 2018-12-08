using Controleur.Commun.ObserverObservable;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Cuisine
{
    // Observer
    public class DishWasher : IObserver<QueueKitchenTools>
    {
        private string name;
        private List<string> queueKitchenToolsInfos = new List<string>();
        private IDisposable cancellation;
        

        public DishWasher(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned a name.");

            this.name = name;
        }

        public virtual void Subscribe(QueueKitchenToolsHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            queueKitchenToolsInfos.Clear();
        }

        public virtual void OnCompleted()
        {
            queueKitchenToolsInfos.Clear();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public virtual void OnError(Exception e)
        {
            // No implementation.
        }

        // Update information.
        public virtual void OnNext(QueueKitchenTools info)
        {
            if (info.KitchenToolsQueue.Count > 0)
            {
                //traitement
                Console.WriteLine("List contains : {1} : elements - {0}", this.name, info.KitchenToolsQueue.Count);
            } else
            {
                //traitement
                Console.WriteLine("List is empty - {0}", this.name);
            }
            
                
        }
    }
}

