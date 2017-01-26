using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia
{
    class Osobowy : Pojazd
    {
        private bool klimatyzacja;
        private bool kombi;

        public override void ObliczKoszt()
        {

        }

    public Osobowy(string marka, string model, double cenaZaDzien, bool klimatyzacja, bool kombi) : base(marka, model, cenaZaDzien)
    { 

            this.klimatyzacja = klimatyzacja;
            this.kombi = kombi;
    }
        public override string ToString()
        {
             return "Osobowy, Marka: " + marka + ", model: "+ model +", cenaZaDzien: " + cenaZaDzien + ", klimatyzacja: " + klimatyzacja + ",kombi: " + kombi;
        }

    }
}
