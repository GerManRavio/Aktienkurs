using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public interface ISubject
    {
        public void Register(IObserver o)
        {
        }

        public void Remove(IObserver o)
        {
        }

        public void Notify()
        {
        }
    }
}