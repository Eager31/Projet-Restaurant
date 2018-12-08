using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.ObserverObservable
{
    //Classe qui va intéragir à la place de QueKitchenTools
    public class QueueKitchenToolsHandler : IObservable<QueueKitchenTools>
    {

        private List<IObserver<QueueKitchenTools>> observers; //Liste des clients qui vont recevoir l'update
        private List<QueueKitchenTools> kitchenToolQeue; //File d'assiette sale

        public QueueKitchenToolsHandler()
        {
            observers = new List<IObserver<QueueKitchenTools>>();
            kitchenToolQeue = new List<QueueKitchenTools>(); //File d'assiette sale
        }

        public IDisposable Subscribe(IObserver<QueueKitchenTools> observer) //Demander à recevoir les infos
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in kitchenToolQeue)
                    observer.OnNext(item);
            }
            return new Unsubscriber<QueueKitchenTools>(observers, observer);
        }
    

    //Permet de récupérer le stats
    public QueueKitchenTools QueueKitchenToosStatus(QueueKitchenTools info)
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
    internal class Unsubscriber<QueueKitchenTools> : IDisposable //Demander à arrêter les notifs jusqu'à stop onCompleted()
    {
        private List<IObserver<QueueKitchenTools>> _observers;
        private IObserver<QueueKitchenTools> _observer;

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

