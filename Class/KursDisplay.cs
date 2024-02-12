using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public class KursDisplay : IObserver
    {
        private Subject aktie;

        public KursDisplay(Subject aktie)
        {
            this.aktie = aktie;
            aktie.RegisterObserver(this);
        }

        public void Update()
        {
            Display(aktie.GetKurswertAktuell());
        }

        private void Display(double wert)
        {
            Console.WriteLine($"Aktueller Kurswert: {wert}");
        }
    }
}