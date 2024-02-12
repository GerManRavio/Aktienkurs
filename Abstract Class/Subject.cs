using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public abstract class Subject : ISubject
    {
        List<IObserver> observers;

        public void Register(IObserver o) {
            observers.Add(o);
        }

        public void Remove(IObserver o) {
            observers.Remove(o);
        }

        public void Notify() {
            foreach(IObserver o in observers) {
                o.Update();
            }
        }
    }
}