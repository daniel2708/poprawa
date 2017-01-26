using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia
{
    class Pojazd : IKoszt
    {
        protected string marka;
        protected string model;
        protected double cenaZaDzien;

        abstract public void ObliczKoszt();


     public Pojazd(string marka, string model, double cenaZaDzien)
        {
            this.marka = marka;
            this.model = model;
            this.cenaZaDzien = cenaZaDzien;
        }


    }
}
