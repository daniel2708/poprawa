using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pojazd> Pojazdy = new List<Pojazd>();
            {
                Pojazdy.Add(new Pojazd("Audi","A1",59));
                Pojazdy.Add(new Pojazd("Audi","A2",90));
                Pojazdy.Add(new Pojazd("Audi","A3",120));
                Pojazdy.Add(new Pojazd("Audi","A4",180));
                Pojazdy.Add(new Pojazd("Audi","A5",240));
                Pojazdy.Add(new Pojazd("Audi","A6",280));
                Pojazdy.Add(new Pojazd("Audi","A7",320));
                Pojazdy.Add(new Pojazd("Audi","A8",240));
                Pojazdy.Add(new Pojazd("Audi","A9",200));
                Pojazdy.Add(new Pojazd("Audi","A10",340));
            }
            for(int i=Pojazdy.Count-2;i>=1;i--)
            {
                Console.WriteLine(wycieczka[i].ToString());
            }

            Wypozyczalnia wypozyczenie = new Wypozyczalnia();
            wypozyczenie1.Dodajwypozyczenie(30, 12);
            wypozyczenie1.Dodajwypozyczenie(90, 42);
            wypozyczenie1.Dodajwypozyczenie(130, 52);
        }
    }
}
