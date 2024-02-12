using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aktienkurs
{
    public class Aktie : Subject
    {
        Double kurswert_Handelsbeginn;
        Double kurswert_aktuell;
        Double kurswert_VeraenderungProzent = Convert.ToDouble(new Random(100));

        public Aktie(Double wertHandelsbeginn) {
         this.kurswert_Handelsbeginn = wertHandelsbeginn;   
        }

        public Double GetKurswertAktuell() {
            return this.kurswert_aktuell;
        }

        public Double GetKurswertProzent() {
            return this.kurswert_VeraenderungProzent;
        }

        public void SetKurswert(Double wert) {
            this.kurswert_VeraenderungProzent = 100 / this.kurswert_Handelsbeginn * (this.kurswert_Handelsbeginn - this.kurswert_aktuell);
            this.kurswert_aktuell = wert;
        }
    }
}