using Controleur.Temps;
using Modèle.Cuisine;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.ObserverObservable
{
    public class ClockHandler : IObservable<Clock>
    {

        public List<IObserver<Clock>> observers { get; set; } //Liste des clients qui vont recevoir l'update
        public List<Clock> clockList { get; set; }

        public ClockHandler()
        {
            observers = new List<IObserver<Clock>>();
            clockList = new List<Clock>(); 
        }

        public IDisposable Subscribe(IObserver<Clock> observer) 
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in clockList)
                    observer.OnNext(item);
            }
            return new Unsubscriber4<Clock>(observers, observer);
        }
    

    //Permet de récupérer le stats
    public Clock ClockStatus(Clock info)
        {
            
            clockList.Add(info);
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
    internal class Unsubscriber4<Clock> : IDisposable //Demander à arrêter les notifs jusqu'à stop onCompleted()
    {
        private List<IObserver<Clock>> _observers;
        private IObserver<Clock> _observer;

        internal Unsubscriber4(List<IObserver<Clock>> observers, IObserver<Clock> observer)
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

