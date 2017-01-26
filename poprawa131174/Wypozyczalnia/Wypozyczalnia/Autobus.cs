using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia
{
    class Autobus  : Pojazd
    {
        private int liczbaMiejsc;

      public override void ObliczKoszt()
          {
            if (liczbaMiejsc > 50) base.cenaZaDzien = liczbaMiejsc * 100;
            else base.cenaZaDzien = cenaZaDzien * liczbaMiejsc;
            }



    public Autobus(string marka, string model, double cenaZaDzien, int liczbaMiejsc) base:( marka, model, cenaZaDzien)
    {
        this.liczbaMiejsc = liczbaMiejsc;
    }

    public override string ToString()
        {
             return "Autobus, Marka: " + marka + ", model: "+ model +", cenaZaDzien: " + cenaZaDzien + ", klimatyzacja: " + klimatyzacja + ",kombi: " + kombi;
        }

    }
}
