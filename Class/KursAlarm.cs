using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public class KursAlarm : IObserver
    {
        private string empfaenger;
        private Subject aktie;

        public KursAlarm(Subject aktie, string empfaenger)
        {
            this.aktie = aktie;
            this.empfaenger = empfaenger;
            aktie.RegisterObserver(this);
        }

        public void Update()
        {
            if (aktie.GetKurswertProzent() <= -20.0)
            {
                SendMessage();
            }
        }

        private void SendMessage()
        {
            Console.WriteLine($"Kursalarm: Kurs der Aktie ist um mindestends 20% gefallen! Benachrichtigung an {empfaenger} gesendet.");
        }
    }
}