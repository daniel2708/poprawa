using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia
{
    class Wypozyczalnia  : IKoszt
    {
        private int ileWolnych;
        private int ileAut;

        public override void ObliczKoszt()
        {

        }

        public Wypozyczalnia(int ileWolnych,int ileAut)
        {
            this.ileWolnych = ileWolnych;
            this.ileAut = ileAut;
        }
    }
}
