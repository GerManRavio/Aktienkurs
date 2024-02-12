using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public class KursDisplay : IObserver
    {
        Subject Aktie;

        public KursDisplay(Subject o)
        {
            System.Console.WriteLine("KursDisplay wurde erstellt");
        }
        public void Update()
        {
            
        }
    }
}