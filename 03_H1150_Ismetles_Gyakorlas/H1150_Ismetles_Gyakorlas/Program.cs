using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1150_Ismetles_Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diak diak1 = new Diak("Péter", "POIAISNOI", 3);
            Console.WriteLine(diak1);

            // Konténer osztály teszt

            Beteg b1 = new Beteg("Sándor", "AB82", 2);
            Beteg b2 = new Beteg("Cintia", "kl93", 1);

            Korhaz korhaz1 = new Korhaz("Markhot Ferenc Kórház", 10);

            korhaz1.Hozzaad(b1);
            korhaz1.Hozzaad(b2);

            Console.WriteLine(korhaz1[0]);
            Console.WriteLine(korhaz1[1]);

            korhaz1.Kivesz(b2);

            Console.ReadKey();
        }
    }
}
