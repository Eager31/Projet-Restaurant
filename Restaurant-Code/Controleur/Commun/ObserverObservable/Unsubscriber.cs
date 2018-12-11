using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.ObserverObservable
{
    internal class Unsubscriber<T> : IDisposable //Demander à arrêter les notifs jusqu'à stop onCompleted()
    {
        public List<IObserver<T>> _observers { get; set; }
        public IObserver<T> _observer { get; set; }

        internal Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
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
