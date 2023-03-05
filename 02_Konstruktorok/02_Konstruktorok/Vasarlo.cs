using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konstruktorok
{
    public class Vasarlo
    {
        // Mezők
        string nev;
        string jelszo;
        string vasarloID;

        // Property-k

        public string Nev 
        {
            get { return nev; }
            set { nev = value; }
        }

        public string Jelszo
        {
            get { return jelszo; }
            set 
            {
                // Jelszó hosszúsági teszt.
                if (value.Length <= 5)
                {
                    Console.WriteLine("Nem elég hosszú jelszó!");
                    return;
                }
                jelszo = value; 
            }
        }

        public string VasarloID
        {
            get { return vasarloID; }
            set { vasarloID = value; }
        }

        // Metódusok

        public void JelszoCsere(string csere)
        {
            Jelszo = csere;
        }

        // Konstruktor

        // Üres konstruktor, alapértelmezett.
        // Nem inicializál semmit.
        // Amennyiben itt jelen van, akkor lehetséges teljesen nem inicializált példányt létrehozni.
        public Vasarlo() { }

        // Teljes inicializáló konstruktor.
        public Vasarlo(string nev, string jelszo, string vasarloID)
        {
            Nev = nev;
            Jelszo = jelszo;
            VasarloID = vasarloID;
        }
    }
}
