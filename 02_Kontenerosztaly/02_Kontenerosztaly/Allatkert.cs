using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Kontenerosztaly
{
    public class Allatkert
    {
        string nev;
        int jegyar;
        int maxfo;
        List<Allat> Allatok = new List<Allat>();

        public string Nev { get { return nev; } set { nev = value; } }
        public int Jegyar { get { return jegyar; } set { jegyar = value; } }
        public int Maxfo { get { return maxfo; } set { maxfo = value; } }

        public Allatkert(string nev, int jegyar, int maxfo)
        {
            this.Nev = nev;
            this.Jegyar = jegyar;
            this.Maxfo = maxfo;
        }

        // Indexer
        public Allat this[int i]
        {
            get { return this.Allatok[i]; }
        }
    }
}
