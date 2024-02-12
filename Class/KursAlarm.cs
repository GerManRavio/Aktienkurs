using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public class KursAlarm : IObserver
    {
        private Subject Aktie;
        String empfaenger;

        private void sendMessage() {
            System.Console.WriteLine(this.empfaenger + ": Aktie fällt!");
        }

        public KursAlarm(Subject o) {
            System.Console.WriteLine("Kursalarm wurde erstellt.");
        }

        public void Update() {
            System.Console.WriteLine("Aktie: ");
        }
    }
}