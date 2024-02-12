using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public class Aktie : Subject
    {
        private double kurswert_Handelsbeginn;
        private double kurswert_aktuell;
        private double kurswert_VeraenderungProzent;

        public Aktie(double wertHandelsbeginn)
        {
            this.kurswert_Handelsbeginn = wertHandelsbeginn;
            this.kurswert_aktuell = wertHandelsbeginn;
        }

        public override double GetKurswertAktuell()
        {
            return kurswert_aktuell;
        }

        public override double GetKurswertProzent()
        {
            return this.kurswert_VeraenderungProzent;
        }

        public void SetKurswert(double wert)
        {
            this.kurswert_VeraenderungProzent = ((wert - kurswert_Handelsbeginn) / kurswert_Handelsbeginn) * 100.0;
            kurswert_aktuell = wert;
            NotifyObservers();
        }
    }
}