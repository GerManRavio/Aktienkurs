using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public abstract class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public abstract double GetKurswertAktuell();
        public abstract double GetKurswertProzent();
    }
}