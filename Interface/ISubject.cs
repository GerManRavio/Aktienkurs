using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}