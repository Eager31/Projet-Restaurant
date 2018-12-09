using Controleur.Cuisine;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.ObserverObservable
{
    public class QueueRoomStuffHandler : IObservable<QueueRoomStuff>
    {

        private List<IObserver<QueueRoomStuff>> observers; //Liste des clients qui vont recevoir l'update
        private List<QueueRoomStuff> qrtList; 

        public QueueRoomStuffHandler()
        {
            observers = new List<IObserver<QueueRoomStuff>>();
            qrtList = new List<QueueRoomStuff>(); 
        }

        public IDisposable Subscribe(IObserver<QueueRoomStuff> observer) //Demander à recevoir les infos
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in qrtList)
                    observer.OnNext(item);
            }
            return new Unsubscriber2<QueueRoomStuff>(observers, observer);
        }


        //Permet de récupérer le stats
        public QueueRoomStuff QueueRoomToolsStatus(QueueRoomStuff info)
        {
            qrtList.Add(info);
                foreach (var observer in observers)
                    observer.OnNext(info);
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
    internal class Unsubscriber2<QueueRoomTools> : IDisposable //Demander à arrêter les notifs jusqu'à stop onCompleted()
    {
        private List<IObserver<QueueRoomTools>> _observers;
        private IObserver<QueueRoomTools> _observer;

        internal Unsubscriber2(List<IObserver<QueueRoomTools>> observers, IObserver<QueueRoomTools> observer)
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

