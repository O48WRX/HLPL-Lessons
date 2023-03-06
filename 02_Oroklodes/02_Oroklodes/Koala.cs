using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Oroklodes
{
    public class Koala : Allat
    {
        // Mezők
        // A Koala rendelkezik az Allat osztály összes mezőjével + amiket itt deklarálunk.
        private string vedettsegiszint;

        public string Vedettsegiszint
        {
            get { return vedettsegiszint; }
            set { vedettsegiszint = value; }
        }

        // Használjuk az Allat osztály konstruktorát, hogy elvégezze a feladatot a mezők inicializálására
        // Valamint az új mezőket pedig mi kezeljük le itt.
        // Ezzel konstruktorhívási láncot tudunk kialakítani.
        public Koala(string nev, int allatID, string vedettsegiszint) : base(nev, allatID)
        {
            this.Vedettsegiszint= vedettsegiszint;
        }

        // Exkluzív metódus, ami csak a koala és leszármazottai számára lesz jelen
        public void felmaszikAFara()
        {
            Console.WriteLine("A koala felmászik a fára!");
        }

        // Viszont ugyanúgy rendelkezünk a meglévő HangotKiad() metódussal mint eddig.
    }
}
