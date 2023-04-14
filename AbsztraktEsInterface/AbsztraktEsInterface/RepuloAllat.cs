using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktEsInterface
{
    // Az absztrakt osztályokban definiálhatjuk az osztály mezőit, metódusait, de jelöljük, hogy ez az osztály még nem teljes és, hogy szükség lesz
    // gyermekosztályra belőle, hogy definiálja.

    // Mikor interfészeket implementálunk kötelező implementálni az interfészben definiált metódusokat is.
    // Először hibát fog dobni, hogy nem implementáljuk a metódusokat, ezt könnyen megoldhatjuk úgy, hogy rámegyünk az interfészre.
    public abstract class RepuloAllat : Allat // és itt a 'ctrl + .' segítségével kiválasztjuk, hogy implement methods. Ez kigenerálja nekünk a metódusokat.
    {
        // Ebben az állapotban fogja őket kigenerálni, ez nyilván számunkra nem jó, mivel mindenféleképpen kivételt fog dobni.

        //public void HangotKiad()
        //{
        //    throw new NotImplementedException();
        //}

        // Két megoldás van:
        // Vagy megjelöljük absztraktnak, hogy majd az absztrakt osztály gyermekei definiálják, hogy mit kell a metódusnak csinálni.

        //public abstract void HangotKiad();

        //Vagy kifejtjük, hogy már ez elérhető legyen a gyermekosztályok számára.
        public void HangotKiad()
        {
            Console.WriteLine("A szárnyas ad ki hangot!");
        }


        // Itt már adhatunk meg mezőket is, meg külön metódusokat, amiket szeretnénk, hogy a gyermekosztályok is örököljenek.

        private string elnevezes;

        public string Elnevezes
        {
            get { return elnevezes; }
            set { elnevezes = value; }
        }

        private int szarnyfesztav;

        public int Szarnyfesztav
        {
            get { return szarnyfesztav; }
            set { szarnyfesztav = value; }
        }

        public RepuloAllat(string elnevezes, int szarnyfesztav)
        {
            this.Elnevezes = elnevezes;
            this.Szarnyfesztav = szarnyfesztav;
        }

        public void Repul()
        {
            Console.WriteLine("Egy {0} repül!", this.Elnevezes);
        }

        // Itt is meglehet, de általában nem írjuk felül a toString és Equals()-t.
    }
}
