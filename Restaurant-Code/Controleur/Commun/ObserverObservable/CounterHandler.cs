using Modèle.Cuisine;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.ObserverObservable
{
    //Classe qui va intéragir à la place de QueKitchenTools
    public class CounterHandler : IObservable<Counter>
    {

        private List<IObserver<Counter>> observers; //Liste des clients qui vont recevoir l'update
        private List<Counter> kitchenToolQeue; //File d'assiette sale

        public CounterHandler()
        {
            observers = new List<IObserver<Counter>>();
            kitchenToolQeue = new List<Counter>(); //File d'assiette sale
        }

        public IDisposable Subscribe(IObserver<Counter> observer) //Demander à recevoir les infos
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in kitchenToolQeue)
                    observer.OnNext(item);
            }
            return new Unsubscriber3<Counter>(observers, observer);
        }
    

    //Permet de récupérer le stats
    public Counter CounterStatus(Counter info)
        {
            //var info = new QueueKitchenTools(); //L'information
            kitchenToolQeue.Add(info);
                foreach (var observer in observers)
                    observer.OnNext(info); //On notifie que le bagage est apparue dans la liste
            return info; //Juste pour le TDD
        }

        public void LastQueueKitchenToolsClaimed()
        {
            foreach (var observer in observers)
                observer.OnCompleted();
            observers.Clear();
        }
    }

}
    internal class Unsubscriber3<Counter> : IDisposable //Demander à arrêter les notifs jusqu'à stop onCompleted()
    {
        private List<IObserver<Counter>> _observers;
        private IObserver<Counter> _observer;

        internal Unsubscriber3(List<IObserver<Counter>> observers, IObserver<Counter> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }

