using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Kontenerosztaly
{
    public class Allat
    {
        // Mezők
        string nev;
        string faj;
        Nem nem;


        // Property-k
        public string Nev 
        { 
            get { return nev; }
            set { nev = value; }
        }

        public string Faj
        {
            get { return faj; }
            set { faj = value; }
        }

        public Nem Nem
        {
            get { return nem; }
            set { nem = value; }
        }

        // Konstruktor
        public Allat(string nev, string faj, Nem nem)
        {
            this.Nev = nev;
            this.Faj = faj;
            this.Nem = nem;
        }
    }
}
