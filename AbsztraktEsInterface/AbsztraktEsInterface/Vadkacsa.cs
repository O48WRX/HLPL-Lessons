using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktEsInterface
{
    // Gyermekosztálya az absztrakt osztálynak, és rendelkezik minden kifejtett metóudsával és mezőjével.
    // Nyilván kibővíthető még másokkal is.
    public class Vadkacsa : RepuloAllat
    {
        private string szin;

        public string Szin
        {
            get { return szin; }
            set { szin = value; }
        }

        public Vadkacsa(string elnevezes, int szarnyfesztav, string szin) : base(elnevezes, szarnyfesztav)
        {
            this.Szin = szin;
        }

        public void LebegAVizen()
        {
            Console.WriteLine("A {0} elnevezésű, {1} színű kacsa lebeg a vizen.", this.Elnevezes, this.Szin);
        }
    }
}
