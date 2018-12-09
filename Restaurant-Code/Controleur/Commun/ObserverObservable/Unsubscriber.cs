using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.ObserverObservable
{
    internal class Unsubscriber<QueueKitchenTools> : IDisposable //Demander à arrêter les notifs jusqu'à stop onCompleted()
    {
        public List<IObserver<QueueKitchenTools>> _observers { get; set; }
        public IObserver<QueueKitchenTools> _observer { get; set; }

        internal Unsubscriber(List<IObserver<QueueKitchenTools>> observers, IObserver<QueueKitchenTools> observer)
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
}
