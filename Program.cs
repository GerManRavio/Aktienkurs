using System;

namespace Aktienkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aktie aktie = new Aktie(100.0);
            KursDisplay kursDisplay = new KursDisplay(aktie);
            KursAlarm kursAlarm = new KursAlarm(aktie, "Eigentümer");

            aktie.SetKurswert(80.0);
            aktie.SetKurswert(120.0);
        }
    }
}